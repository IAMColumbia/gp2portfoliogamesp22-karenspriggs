using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonPlantStore
{
    public Dictionary<string, MonsterPlant> monPlantsForSale;

    public MonPlantStore()
    {
        this.monPlantsForSale = MonPlantFactory.Instance.monPlantDictionary;
    }

    public void SellMonPlant(string key)
    {
        // Bruh idk
        Player.Instance.playerInventory.AddMonPlant(monPlantsForSale[key]);
    }

    string PrintStock()
    {
        string message = "";

        foreach(MonsterPlant mp in monPlantsForSale.Values)
        {
            message += mp.plantMonKey;
        }

        return message;
    }
}
