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
        monDictionary.Add("SunflowerLion", new Monster("SunflowerLion"));
        monDictionary.Add("Advodoggo", new Monster("Advodoggo"));
        monDictionary.Add("Strawbunny", new Monster("Strawbunny"));
        monDictionary.Add("Raccorn", new Monster("Raccorn"));
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
