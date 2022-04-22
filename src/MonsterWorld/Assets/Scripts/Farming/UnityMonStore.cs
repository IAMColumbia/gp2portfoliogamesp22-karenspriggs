using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityMonStore : MonoBehaviour
{
    MonPlantStore monPlantStore;
    public Text playerInventoryList;
    public GameObject Menu;

    void Start()
    {
        monPlantStore = new MonPlantStore();
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

    public void HideSelf()
    {
        Menu.SetActive(false);
    }

    //void UpdateText()
    //{
    //    playerInventoryList.text = Player.Instance.playerInventory.PrintMonPlantInventory();
    //}
}
