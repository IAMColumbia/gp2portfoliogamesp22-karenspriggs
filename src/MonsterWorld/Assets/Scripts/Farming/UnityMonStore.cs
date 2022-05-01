using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityMonStore : MonoBehaviour
{
    MonPlantStore monPlantStore;
    public Text playerInventoryList;
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
        monPlantStore.SellMonPlant("SunflowerLion");
        //UpdateText();
    }

    public void BuyAdvodoggo()
    {
        monPlantStore.SellMonPlant("Advodoggo");
        //UpdateText();
    }

    public void BuyStrawbunny()
    {
        monPlantStore.SellMonPlant("Strawbunny");
        //UpdateText();
    }

    public void BuyRaccorn()
    {
        monPlantStore.SellMonPlant("Raccorn");
        //UpdateText();
    }

    public void ShowSelf()
    {
        Player.Instance.canMove = false;
        Menu.SetActive(true);
        beingShown = true;
    }

    public void HideSelf()
    {
        Player.Instance.canMove = true;
        Menu.SetActive(false);
        beingShown = false;
    }
}
