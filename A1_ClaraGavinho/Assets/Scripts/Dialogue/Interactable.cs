using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindAnyObjectByType<DialogueManager>().StartDialogue(dialogue);
    }
}
