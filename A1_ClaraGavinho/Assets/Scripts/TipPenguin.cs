using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TipPenguin : MonoBehaviour
{
    [SerializeField] private ARPlaneManager planeManager;
    [SerializeField] private GameObject penguinPrefab;
    //[SerializeField] private DialogueManager 

    private bool _isDialogueOver = false;

    private bool _canSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPenguin();
    }

    public void SpawnPenguin()
    {
        if (_isDialogueOver) return;

        foreach (ARPlane plane in planeManager.trackables)
        {
            if (_isDialogueOver)
            {
                Destroy(penguinPrefab);
                _canSpawn = false;
            }

            if (plane.alignment == PlaneAlignment.HorizontalUp)
            {
                
            }
        }
    }
}
