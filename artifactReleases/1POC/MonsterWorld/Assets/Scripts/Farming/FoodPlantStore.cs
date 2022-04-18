using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPlantStore
{
    public Dictionary<string, FoodPlant> foodPlantsForSale;

    public FoodPlantStore()
    {
        this.foodPlantsForSale = FoodPlantFactory.Instance.foodPlantDictionary;
    }

    public void SellFoodPlant(string key)
    {
        // Bruh idk
        Player.Instance.playerInventory.AddFoodPlant(foodPlantsForSale[key]);
    }

    string PrintStock()
    {
        string message = "";

        foreach (FoodPlant fp in foodPlantsForSale.Values)
        {
            message += fp.foodKey;
        }

        return message;
    }
}
