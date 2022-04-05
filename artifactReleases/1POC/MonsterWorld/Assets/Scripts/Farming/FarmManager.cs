using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager
{
    public List<Monster> farmMonsters;
    public List<Monster> playerMonsters;
    public List<Food> playerFood;
    private static FarmManager instance;

    public static FarmManager Instance
    {
        get
        {
            if (instance == null)
            {
                
                instance = new FarmManager();
            }

            return instance;
        }
    }
    
    public FarmManager()
    {
        farmMonsters = new List<Monster>();
        Debug.Log("Created farm manager");
        playerMonsters = new List<Monster>();
        playerFood = new List<Food>();
    }

    public void PrintMonsterList()
    {
        foreach(Monster m in farmMonsters)
        {
            Debug.Log(m.battleStats.Name);
        }
    }
}
