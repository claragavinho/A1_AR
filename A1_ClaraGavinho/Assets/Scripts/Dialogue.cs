using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "DialogueSO", menuName = "Scriptable Objects/DialogueSo")]
public class DialogueSO : ScriptableObject
{
    public List<Dialogue> dialogueLines = new List<Dialogue>();
    public bool isDialogueOver;
}

[System.Serializable]
public class Dialogue
{
    [TextArea(3, 10)]
    public string[] sentences;
}
