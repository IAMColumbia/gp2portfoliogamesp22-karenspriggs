using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTrigger : MonoBehaviour
{
    Dialogue battleDialogue;

    public List<string> dialogueLines;

    bool triggerActive = false;

    public Text dialogueText;
    public GameObject dialogueBox;

    public Text interactionText;

    private void Start()
    {
        battleDialogue = new Dialogue(dialogueLines, dialogueText, dialogueBox);
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            interactionText.gameObject.SetActive(false);

            if (!battleDialogue.DialogueStarted)
            {
                battleDialogue.ShowDialogue();
            }
            else
            {
                if (!battleDialogue.DialogueOver)
                {
                    battleDialogue.PrintLine();
                } else
                {
                    dialogueBox.gameObject.SetActive(false);
                    //MonsterMenuUI.SharedInstance.canOpen = false;
                    GameManager.SharedInstance.TurnOnBattleState();
                }
            }   
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            triggerActive = true;
            interactionText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            triggerActive = false;
            interactionText.gameObject.SetActive(false);
        }
    }
}
