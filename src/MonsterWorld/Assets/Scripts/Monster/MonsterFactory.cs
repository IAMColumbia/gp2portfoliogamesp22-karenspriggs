using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory
{
    private static MonsterFactory instance;
    public static MonsterFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MonsterFactory();
            }

            return instance;
        }
    }

    public Dictionary<string, Monster> monDictionary;

    public MonsterFactory()
    {
        monDictionary = new Dictionary<string, Monster>();
        FillDictionary();
    }

    void FillDictionary()
    {
        monDictionary.Add("SunflowerLion", new Monster("SunflowerLion", "Sprites/littlestinkylion"));
        monDictionary.Add("Advodoggo", new Monster("Advodoggo", "Sprites/advodogo"));
        monDictionary.Add("Strawbunny", new Monster("Strawbunny", "Sprites/strawbunny"));
        monDictionary.Add("Raccorn", new Monster("Raccorn", "Sprites/raccorn"));
        monDictionary.Add("Tomatoad", new Monster("Tomatoad", "Sprites/tomatoad"));
        monDictionary.Add("Giraffodil", new Monster("Giraffodil", "Sprites/giraffodil"));
        monDictionary.Add("Pumpkitty", new Monster("Pumpkitty", "Sprites/pumpkitty"));

        monDictionary.Add("BossTomatoad", new Monster("BossTomatoad", "Sprites/tomatoad"));
        monDictionary.Add("BossGiraffodil", new Monster("BossGiraffodil", "Sprites/giraffodil"));
        monDictionary.Add("BossPumpkitty", new Monster("BossPumpkitty", "Sprites/pumpkitty"));
    }

    public Monster GetMon(string value)
    {
        Monster m = null;

        if (monDictionary.ContainsKey(value))
        {
            m = monDictionary[value];
        }
        else
        {
            Debug.Log($"{value} is not a monster");
        }

        return m;
    }
}
