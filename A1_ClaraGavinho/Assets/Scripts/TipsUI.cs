using UnityEngine;

public class TipsUI : MonoBehaviour
{
    private TMPro.TMP_Text text;
    private int count;
    
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start()
    {
        UpdateCount();
    }

    void OnEnable()
    {
        TipsCollectable.OnCollected += () => OnCollectableCollected();
    }

    void OnDisable()
    {
        TipsCollectable.OnCollected -= () =>OnCollectableCollected();
    }
    void OnCollectableCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {TipsCollectable.total}";
    }
}
