using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipsUI : MonoBehaviour
{
    private TMPro.TMP_Text text;
    private TipsCollectable tipsRef;
    private int count;
    
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
        tipsRef = GetComponent<TipsCollectable>();
    }
    void OnEnable()
    {
        //tipsRef.OnCollected += UpdateCount;
        TipsCollectable.OnCollected += () => OnCollectableCollected();
    }

    void OnDisable()
    {
        //tipsRef.OnCollected -= UpdateCount;
    }
    void Start()
    {
        UpdateCount();
        count = 0;
    }
    void OnCollectableCollected()
    {
        count++;
        UpdateCount();
    }

    private void UpdateCount()
    {
        //collectedAmount++;
        text.text = $"{count} / {5}";
        if (count >= 5)
            SceneManager.LoadScene("EndScene");
    }
}
