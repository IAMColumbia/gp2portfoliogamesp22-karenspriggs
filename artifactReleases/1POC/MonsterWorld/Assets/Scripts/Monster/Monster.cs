using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public BattleStats battleStats;
    public MonsterMovement monMonvement;

    public float speed;
    public int max;

    public Monster()
    {
        battleStats = new BattleStats();
    }

    private void Start()
    {
        monMonvement = new MonsterMovement();
        monMonvement.position = this.transform.position;
        monMonvement.Speed = speed;
        monMonvement.max = max;
    }

    private void Update()
    {
        monMonvement.DetermineState();
        this.transform.position = monMonvement.position;
    }

}
