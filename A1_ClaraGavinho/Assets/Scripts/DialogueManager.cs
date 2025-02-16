using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] public GameObject UI;
    public TMP_Text dialogueText;
    public UnityEvent OnDialogueEnd;
    private Queue<string> sentences;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.SetActive(false);
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        UI.SetActive(true);
        sentences.Clear();
        
        foreach(string sentence in dialogue.sentences)
            sentences.Enqueue(sentence);
        
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0) 
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        UI.SetActive(false);
        OnDialogueEnd.Invoke();
    }
}
