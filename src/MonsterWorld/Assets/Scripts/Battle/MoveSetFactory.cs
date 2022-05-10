using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSetFactory
{
    private static MoveSetFactory instance;
    public static MoveSetFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MoveSetFactory();
            }

            return instance;
        }
    }

    public Dictionary<string, MoveSet> movesetDictionary;

    public MoveSetFactory()
    {
        movesetDictionary = new Dictionary<string, MoveSet>();
        FillDictionary();
    }

    void FillDictionary()
    {
        movesetDictionary.Add("Default", new MoveSet());
        movesetDictionary.Add("Fruit", new MoveSet("FruitSlash", "FruitStomp", "FruitRoar", "FruitScratch"));
        movesetDictionary.Add("Veggie", new MoveSet("VeggieBite", "VeggieBlast", "VeggieChop", "VeggieKick"));
        movesetDictionary.Add("Flower", new MoveSet("FlowerWaltz", "FlowerBite", "FlowerSlash", "FlowerPunch"));
    }

    public MoveSet GetMoveSet(string value)
    {
        MoveSet ms = null;

        if (movesetDictionary.ContainsKey(value))
        {
            ms = movesetDictionary[value];
        }
        else
        {
            Debug.Log($"{value} is not a moveset");
        }

        return ms;
    }
}
