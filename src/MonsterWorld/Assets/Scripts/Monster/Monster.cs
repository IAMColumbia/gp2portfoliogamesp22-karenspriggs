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

    public void FeedMonster(Food f)
    {
        if (Player.Instance.playerInventory.GetAmountOfFood(f.Name) > 0)
        {
            f.Feed(this.battleStats.MonsterStats);
            Player.Instance.playerInventory.RemoveOneFood(f.Name);
        }
    }
}
