using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue
{
    public List<string> dialogue;

    public Text dialogueText;
    public GameObject dialogueBox;

    public int index = 0;

    public bool DialogueOver;
    public bool DialogueStarted;

    public Dialogue(List<string> lines, Text dialogueText, GameObject dialogueBox)
    {
        this.dialogue = lines;
        this.dialogueText = dialogueText;
        this.dialogueBox = dialogueBox;

        dialogueBox.SetActive(false);
    }

    public void ShowDialogue()
    {
        dialogueBox.gameObject.SetActive(true);
        dialogueText.text = dialogue[index];
        DialogueStarted = true;
    }

    public void PrintLine()
    {
        if (index < dialogue.Count - 1)
        {
            index++;
            dialogueText.text = dialogue[index];
        }
        else
        {
            DialogueOver = true;
        }
    }
}
