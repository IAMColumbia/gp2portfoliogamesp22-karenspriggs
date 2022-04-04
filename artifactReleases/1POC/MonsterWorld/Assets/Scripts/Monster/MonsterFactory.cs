using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory
{
    private MonsterFactory instance;
    public MonsterFactory Instance
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
            
        }

        return m;
    }
}
