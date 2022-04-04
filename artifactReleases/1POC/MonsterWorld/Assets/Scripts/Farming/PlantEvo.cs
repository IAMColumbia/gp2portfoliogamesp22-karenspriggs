using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlantEvoState
{
    Seed,
    Sprout,
    Plant
}

public class PlantEvo
{
    public PlantEvoState evoState;
    public Sprite currentSprite;
    public Sprite sproutSprite;
    public Sprite plantSprite;

    public string plantMonKey;
    public Monster plantMon;

    public bool hasGrown;

    public PlantEvo()
    {
        Setup();
    }

    void Setup()
    {
        this.evoState = PlantEvoState.Seed;
        this.currentSprite = Resources.Load<Sprite>("Sprites/seed");
        this.sproutSprite = Resources.Load<Sprite>("Sprites/sprout");
        this.plantSprite = Resources.Load<Sprite>("Sprites/plant");

        hasGrown = false;
    }

    public void Evolve()
    {
        switch (this.evoState)
        {
            case (PlantEvoState.Seed):
                this.evoState = PlantEvoState.Sprout;
                this.currentSprite = sproutSprite;
                break;
            case (PlantEvoState.Sprout):
                this.evoState = PlantEvoState.Plant;
                this.currentSprite = plantSprite;
                break;
            case (PlantEvoState.Plant):
                GrowMonster();
                break;
        }

        Debug.Log(evoState);
    }

    public void GrowMonster()
    {
        hasGrown = true;
        FarmManager.Instance.farmMonsters.Add(plantMon);
        Debug.Log("Added a monster");
        FarmManager.Instance.PrintMonsterList();
    }

    public Sprite SetCurrentSprite()
    {
        return currentSprite;
    }
}