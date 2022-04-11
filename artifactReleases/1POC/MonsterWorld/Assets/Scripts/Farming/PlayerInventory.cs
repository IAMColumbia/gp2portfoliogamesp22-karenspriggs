using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory 
{
    public List<Monster> playerMonsters;
    public List<Food> playerFood;

    public PlayerInventory()
    {
        playerMonsters = new List<Monster>();
        playerFood = new List<Food>();
    }

    public void AddMonster(Monster m)
    {
        this.playerMonsters.Add(m);
    }

    public void AddFood(Food f)
    {
        this.playerFood.Add(f);
    }

    public Monster GetBattler(int index)
    {
        return playerMonsters[index];
    }
}
