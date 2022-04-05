using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    public BattleStats battleStats;
    public MonsterMovement monMonvement;

    public Monster(string _statsKey)
    {
        this.battleStats = BattleStatsFactory.Instance.GetStats(_statsKey);
    }
}
