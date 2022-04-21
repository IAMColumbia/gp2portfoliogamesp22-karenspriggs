using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPlantPlot : PlantPlot
{
    public MonsterPlant plantInPlot;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        //SetMonsterPlant(MonPlantFactory.Instance.GetMonPlant("SunflowerLion"));

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

    public void SetMonsterPlant(MonsterPlant mp)
    {
        this.plantInPlot = mp;
        this.plotStatus = PlotStatus.Occupied;
        UpdateSprite(mp);
    }

    void UpdateSprite(MonsterPlant mp)
    {
        spriteRenderer.sprite = mp.plantEvo.SetCurrentSprite();

        if (mp.plantEvo.hasGrown)
        {
            Player.Instance.playerInventory.AddMonster(mp.monster);
        }
    }

    void CheckIfGrown()
    {
        if (plantInPlot.plantEvo.hasGrown)
        {
            Player.Instance.playerInventory.AddMonster(plantInPlot.monster);
            this.spriteRenderer.sprite = null;
            this.plotStatus = PlotStatus.Empty;
        }
    }
}
