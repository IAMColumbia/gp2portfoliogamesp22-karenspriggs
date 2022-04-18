using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFoodStore : MonoBehaviour
{
    FoodPlantStore foodPlantStore;

    void Start()
    {
        foodPlantStore = new FoodPlantStore();
    }

    // Connect to UI

    public void BuyHPBerry()
    {
        foodPlantStore.SellFoodPlant("HP Berry");
    }

    public void BuyATKBerry()
    {
        foodPlantStore.SellFoodPlant("ATK Berry");
    } 

    public void BuyDEFBerry() 
    {
        foodPlantStore.SellFoodPlant("DEF Berry");
    }

    public void BuySPDBerry()
    {
        foodPlantStore.SellFoodPlant("SPD Berry");
    }
}
