using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager
{
    public List<Monster> farmMonsters;
    public MonsterStorage monsterStorage;
    
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
        monsterStorage = new MonsterStorage();
        //Debug.Log("Created farm manager");
    }

    public void PrintMonsterList()
    {
        foreach(Monster m in farmMonsters)
        {
            Debug.Log(m.battleStats.Name);
        }
    }
}
