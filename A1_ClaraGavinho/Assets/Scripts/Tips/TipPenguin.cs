using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TipPenguin : MonoBehaviour
{
    [SerializeField] private ARPlaneManager planeManager;
    [SerializeField] private GameObject penguinPrefab;

    [SerializeField] private GameObject UI;
    //[SerializeField] private DialogueManager 

    private bool _isPenguinPlaced = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _isPenguinPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPenguin();
    }

    public void SpawnPenguin()
    {
        if (_isPenguinPlaced) return;

        foreach (ARPlane plane in planeManager.trackables)
        {
            if (plane.alignment == PlaneAlignment.HorizontalUp)
            {
                if (_isPenguinPlaced) break;
                
                if (plane.alignment == PlaneAlignment.HorizontalUp)
                {
                    _isPenguinPlaced = true;
                    UI.SetActive(true);
                    Instantiate(penguinPrefab, plane.transform.position, Quaternion.identity);
                }
            }
        }
    }
}
