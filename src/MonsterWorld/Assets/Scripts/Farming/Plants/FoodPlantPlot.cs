using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPlantPlot : PlantPlot
{
    public FoodPlant plantInPlot;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        SetFoodPlant(FoodPlantFactory.Instance.GetFoodPlant("HP Berry"));

        if (plotStatus == PlotStatus.Occupied)
        {
            UpdateSprite(plantInPlot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (plotStatus == PlotStatus.Occupied)
            {
                plantInPlot.plantEvo.Evolve();
                UpdateSprite(plantInPlot);
                CheckIfGrown();
            }
        }
    }

    public void SetFoodPlant(FoodPlant fp)
    {
        this.plantInPlot = fp;
        this.plotStatus = PlotStatus.Occupied;
        UpdateSprite(fp);
    }

    void UpdateSprite(FoodPlant fp)
    {
        this.spriteRenderer.sprite = fp.plantEvo.SetCurrentSprite();
    }

    void CheckIfGrown()
    {
        if (plantInPlot.plantEvo.hasGrown)
        {
            Player.Instance.playerInventory.AddFood(plantInPlot.food);
            this.spriteRenderer.sprite = null;
            this.plotStatus = PlotStatus.Empty;
        }
    }
}
