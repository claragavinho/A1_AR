using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TipsCollectable : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;

    public static int endTotal = 5;

    void Awake()
    {
        total++;
    }
    
    public void CollectTip()
    {
        OnCollected?.Invoke();
        if (total == endTotal)
            SceneManager.LoadScene(sceneName: "EndScene");
    }

    public void EndGame()
    {
        if (total == endTotal)
            SceneManager.LoadScene(sceneName: "EndScene");
    }
}
