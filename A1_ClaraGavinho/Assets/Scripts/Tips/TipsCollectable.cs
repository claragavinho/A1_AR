using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TipsCollectable : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;

    void Awake()
    {
        total++;
    }
    public void CollectTip()
    {
        OnCollected?.Invoke();
    }

    public void EndGame()
    {
        if (total == 5)
            SceneManager.LoadScene(sceneName: "EndScene");
    }
}
