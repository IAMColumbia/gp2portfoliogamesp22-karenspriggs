using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityFoodStore : MonoBehaviour
{
    FoodPlantStore foodPlantStore;
    public Text resultText;
    public GameObject Menu;

    void Start()
    {
        foodPlantStore = new FoodPlantStore();
    }

    // Connect to UI

    public void BuyHPBerry()
    {
        resultText.text = foodPlantStore.SellFoodPlant("HP Berry");
    }

    public void BuyATKBerry()
    {
        resultText.text = foodPlantStore.SellFoodPlant("ATK Berry");
    } 

    public void BuyDEFBerry() 
    {
        resultText.text = foodPlantStore.SellFoodPlant("DEF Berry");
    }

    public void BuySPDBerry()
    {
        resultText.text = foodPlantStore.SellFoodPlant("SPD Berry");
    }

    public void HideSelf()
    {
        Player.Instance.canMove = true;
        Menu.SetActive(false);
    }
}
