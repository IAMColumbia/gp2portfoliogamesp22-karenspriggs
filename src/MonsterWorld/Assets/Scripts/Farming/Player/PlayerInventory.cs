using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private List<Monster> playerMonsters;
    private List<Food> playerFood;
    private List<MonsterPlant> playerMonPlants;
    private List<FoodPlant> playerFoodPlants;

    private int maxTeamSize;

    public PlayerInventory()
    {
        playerMonsters = new List<Monster>();
        playerFood = new List<Food>();
        maxTeamSize = 3;

        AddMonster(MonsterFactory.Instance.GetMon("Advodoggo"));
        AddMonster(MonsterFactory.Instance.GetMon("SunflowerLion"));
        AddMonster(MonsterFactory.Instance.GetMon("Raccorn"));
    }

    public void AddMonster(Monster m)
    {
        this.playerMonsters.Add(m);
    }

    public Monster ReturnMonster(int index)
    {
        return playerMonsters[index];
    }

    public bool CanAddMonster()
    {
        return playerMonsters.Count + 1 <= maxTeamSize;
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

    public string PrintMonsterInfo(int index)
    {
        return playerMonsters[index].battleStats.Describe();
    }

    public string PrintMonsterName(int index)
    {
        return playerMonsters[index].battleStats.Name; 
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

    public int GetAmountOfFood(string key)
    {
        int amount = 0;

        foreach(Food f in playerFood)
        {
            if (key == f.Name)
            {
                amount++;
            }
        }

        return amount;
    }

    public void RemoveOneFood(string key)
    {
        int index = 0;

        for (int i = 0; i < playerFood.Count; i++)
        {
            if (playerFood[i].Name == key)
            {
                index = i;
            }
        }

        playerFood.Remove(playerFood[index]);
    }
}
