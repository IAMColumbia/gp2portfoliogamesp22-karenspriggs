using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPlant : Plant
{
    public UnityFood unityFood;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        unityFood.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Evolve");
            EvolvePlant();
        }
    }

    protected override void EvolvePlant()
    {
        base.EvolvePlant();

        if (plantEvo.hasGrown)
        {
            unityFood.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    void GrowFood()
    {
        FarmManager.Instance.playerFood.Add(unityFood.food);
        Debug.Log("Added a fruit");
    }
}
