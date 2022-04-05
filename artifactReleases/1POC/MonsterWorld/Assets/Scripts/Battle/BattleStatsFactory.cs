using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStatsFactory
{
    private static BattleStatsFactory instance;
    public static BattleStatsFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new BattleStatsFactory();
            }

            return instance;
        }
    }

    public Dictionary<string, BattleStats> statsDictionary;

    public BattleStatsFactory()
    {
        statsDictionary = new Dictionary<string, BattleStats>();
    }

    public BattleStats GetStats(string value)
    {
        BattleStats bs = null;

        if (statsDictionary.ContainsKey(value))
        {
            bs = statsDictionary[value];
        }
        else
        {
            switch (value)
            {
                case ("SunflowerLion"):
                    bs = new BattleStats(BattleTypeDatabase.FlowerType, "Default", "SunflowerLion");
                    break;
                case ("Advodoggo"):
                    bs = new BattleStats(BattleTypeDatabase.FruitType, "Default", "Advodoggo");
                    break;
                case ("Strawbunny"):
                    bs = new BattleStats(BattleTypeDatabase.FruitType, "Default", "Strawbunny");
                    break;
            }
        }

        return bs;
    }
}
