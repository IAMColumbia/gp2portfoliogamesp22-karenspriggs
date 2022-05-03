using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityMonStore : MonoBehaviour
{
    MonPlantStore monPlantStore;

    public Text resultsText;
    public GameObject Menu;

    public Text interactionText;

    bool triggerActive = false;
    bool beingShown = false;

    void Start()
    {
        monPlantStore = new MonPlantStore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactionText.gameObject.SetActive(true);
            triggerActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactionText.gameObject.SetActive(false);
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && !beingShown && Input.GetKeyDown(KeyCode.Space))
        {
            ShowSelf();
        }
    }

    public void BuySunflowerLion()
    {
        resultsText.text = monPlantStore.SellMonPlant("SunflowerLion");
        //UpdateText();
    }

    public void BuyAdvodoggo()
    {
        resultsText.text = monPlantStore.SellMonPlant("Advodoggo");
        //UpdateText();
    }

    public void BuyStrawbunny()
    {
        resultsText.text = monPlantStore.SellMonPlant("Strawbunny");
        //UpdateText();
    }

    public void BuyRaccorn()
    {
        resultsText.text = monPlantStore.SellMonPlant("Raccorn");
        //UpdateText();
    }

    public void BuyTomatoad()
    {
        if (Player.Instance.canBuyTomatoad)
        {
            resultsText.text = monPlantStore.SellMonPlant("Tomatoad");
        } else
        {
            resultsText.text = "You have not unlocked this monster yet";
        }
    }

    public void BuyGiraffodil()
    {
        if (Player.Instance.canBuyTomatoad)
        {
            resultsText.text = monPlantStore.SellMonPlant("Giraffodil");
        }
        else
        {
            resultsText.text = "You have not unlocked this monster yet";
        }
    }

    public void BuyPumpkitty()
    {
        if (Player.Instance.canBuyPumpkitty)
        {
            resultsText.text = monPlantStore.SellMonPlant("Pumpkitty");
        }
        else
        {
            resultsText.text = "You have not unlocked this monster yet";
        }
    }

    public void ShowSelf()
    {
        Player.Instance.canMove = false;
        //GameManager.SharedInstance.uiManager.canOpenMonMenu = false;
        Menu.SetActive(true);
        beingShown = true;
    }

    public void HideSelf()
    {
        Player.Instance.canMove = true;
        //GameManager.SharedInstance.uiManager.canOpenMonMenu = true;
        Menu.SetActive(false);
        beingShown = false;
    }
}
