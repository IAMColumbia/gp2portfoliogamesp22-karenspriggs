using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFactory
{
    private static FoodFactory instance;
    public static FoodFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new FoodFactory();
            }

            return instance;
        }
    }

    public Dictionary<string, Food> foodDictionary;

    public FoodFactory()
    {
        foodDictionary = new Dictionary<string, Food>();
    }

    public Food GetFood(string value)
    {
        Food f = null;

        if (foodDictionary.ContainsKey(value))
        {
            f = foodDictionary[value];
        }
        else
        {
            switch (value)
            {
                case ("HP Berry"):
                    f = new Food("HP Berry", 0, 1, "Sprites/hpberry");
                    foodDictionary.Add("HP Berry", f);
                    break;
                case ("ATK Berry"):
                    f = new Food("ATK Berry", 1, 1, "Sprites/attackberry");
                    foodDictionary.Add("ATK Berry", f);
                    break;
                case ("DEF Berry"):
                    f = new Food("DEF Berry", 2, 1, "Sprites/defberry");
                    foodDictionary.Add("DEF Berry", f);
                    break;
                case ("SPD Berry"):
                    f = new Food("SPD Berry", 3, 1, "Sprites/speedberry");
                    foodDictionary.Add("SPD Berry", f);
                    break;
            }
        }

        return f;
    }
}
