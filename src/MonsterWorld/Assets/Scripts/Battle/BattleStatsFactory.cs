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
        FillDictionary();
    }

    void FillDictionary()
    {
        statsDictionary.Add("SunflowerLion", new BattleStats(BattleTypeDatabase.FlowerType, "Flower", "SunflowerLion"));
        statsDictionary.Add("Advodoggo", new BattleStats(BattleTypeDatabase.FruitType, "Fruit", "Advodoggo"));
        statsDictionary.Add("Strawbunny", new BattleStats(BattleTypeDatabase.FruitType, "Fruit", "Strawbunny"));
        statsDictionary.Add("Raccorn", new BattleStats(BattleTypeDatabase.VeggieType, "Veggie", "Raccorn"));
        statsDictionary.Add("Tomatoad", new BattleStats(BattleTypeDatabase.FruitType, "Fruit", "Tomatoad"));
        statsDictionary.Add("Giraffodil", new BattleStats(BattleTypeDatabase.FlowerType, "Flower", "Giraffodil"));
        statsDictionary.Add("Pumpkitty", new BattleStats(BattleTypeDatabase.VeggieType, "Veggie", "Pumpkitty"));

        //Boss Monsters
        statsDictionary.Add("BossTomatoad", new BattleStats(BattleTypeDatabase.FruitType, "Fruit", "Tomatoad", "Boss"));
        statsDictionary.Add("BossGiraffodil", new BattleStats(BattleTypeDatabase.FlowerType, "Flower", "Giraffodil", "Boss"));
        statsDictionary.Add("BossPumpkitty", new BattleStats(BattleTypeDatabase.VeggieType, "Veggie", "Pumpkitty", "Boss"));
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
            Debug.Log($"{value} is not a monster");
        }

        return bs;
    }
}
