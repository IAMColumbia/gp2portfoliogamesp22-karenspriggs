using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory 
{
    private List<Monster> playerMonsters;
    private List<Food> playerFood;
    private List<MonsterPlant> playerMonPlants;
    private List<FoodPlant> playerFoodPlants;

    public PlayerInventory()
    {
        playerMonsters = new List<Monster>();
        playerFood = new List<Food>();

        AddMonster(MonsterFactory.Instance.GetMon("Advodoggo"));
    }

    public void AddMonster(Monster m)
    {
        this.playerMonsters.Add(m);
    }

    public void AddFood(Food f)
    {
        this.playerFood.Add(f);
    }

    public void AddMonPlant(MonsterPlant mp)
    {
        this.playerMonPlants.Add(mp);
    }

    public void AddFoodPlant(FoodPlant fp)
    {
        this.playerFoodPlants.Add(fp);
    }

    public string PrintMonPlantInventory()
    {
        string message = "";

        foreach (MonsterPlant mp in playerMonPlants)
        {
            message += mp.plantMonKey;
            message += "\n";
        }

        return message;
    }

    public string PrintFoodPlantInventory()
    {
        string message = "";

        foreach (FoodPlant fp in playerFoodPlants)
        {
            message += fp.foodKey;
            message += "\n";
        }

        return message;
    }

    public Monster GetBattler(int index)
    {
        return playerMonsters[index];
    }
}
