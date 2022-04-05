using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPlant : Plant
{
    public Monster monster;
    public string plantMonKey;
    public UnityMonster uMonster;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        //monster.gameObject.SetActive(false);
        uMonster.gameObject.SetActive(false);
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
            //monster.gameObject.SetActive(true);
            uMonster.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    void GrowMonster()
    {
        FarmManager.Instance.farmMonsters.Add(uMonster.monster);
        Debug.Log("Added a monster");
    }
}
