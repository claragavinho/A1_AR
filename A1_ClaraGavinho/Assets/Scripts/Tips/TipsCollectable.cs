using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TipsCollectable : MonoBehaviour
{
    //public event Action <int> OnCollected;
    public static event Action OnCollected;
    public int total;

    public int endTotal = 5;

    void Awake()
    {
        total = 0;
    }
    public void CollectTip()
    {
        total++;
        OnCollected?.Invoke();
    }
}
