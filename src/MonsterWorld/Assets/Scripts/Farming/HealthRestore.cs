using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRestore : MonoBehaviour
{
    public Text interactionText;
    bool inTrigger = false;

    // Update is called once per frame
    void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            HealPlayerTeam();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inTrigger = true;
            interactionText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inTrigger = false;
            interactionText.gameObject.SetActive(false);
            interactionText.text = "Press Space to\nheal your team";
        }
    }

    void HealPlayerTeam()
    {
        foreach(Monster m in Player.Instance.playerInventory.PlayerMonsters)
        {
            m.battleStats.FillHP();
        }

        interactionText.text = "Team healed";
    }
}
