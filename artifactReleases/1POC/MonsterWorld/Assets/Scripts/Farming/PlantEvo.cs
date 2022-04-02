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
    public string plantMonKey;
    public Monster plantMon;
    bool hasGrown;

    public PlantEvo()
    {
        Setup();
    }

    void Setup()
    {
        this.evoState = PlantEvoState.Seed;
        //this.currentSprite = 
        hasGrown = false;
    }

    public void Evolve()
    {
        switch (this.evoState)
        {
            case (PlantEvoState.Seed):
                this.evoState = PlantEvoState.Sprout;
                break;
            case (PlantEvoState.Sprout):
                this.evoState = PlantEvoState.Plant;
                break;
            case (PlantEvoState.Plant):
                hasGrown = true;
                break;
        }
    }
}
