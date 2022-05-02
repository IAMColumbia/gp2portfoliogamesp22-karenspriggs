using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster
{
    public BattleStats battleStats;
    public MonsterMovement monMonvement;
    public Sprite monsterSprite;

    public Monster(string _statsKey)
    {
        this.battleStats = BattleStatsFactory.Instance.GetStats(_statsKey);
    }

    public Monster(string _statsKey, string _spritePath)
    {
        battleStats = new BattleStats();
        CopyBattleStats(BattleStatsFactory.Instance.GetStats(_statsKey));
        this.monsterSprite = Resources.Load<Sprite>(_spritePath);
    }

    public void CopyBattleStats(BattleStats OGBattleStats)
    {
        this.battleStats.Name = OGBattleStats.Name;
        this.battleStats.MonsterStats.MaxHP = OGBattleStats.MonsterStats.MaxHP;
        this.battleStats.MonsterStats.Attack = OGBattleStats.MonsterStats.Attack;
        this.battleStats.MonsterStats.Defense = OGBattleStats.MonsterStats.Defense;
        this.battleStats.MonsterStats.Speed = OGBattleStats.MonsterStats.Speed;
        this.battleStats.MonsterMoveSet = OGBattleStats.MonsterMoveSet;
        this.battleStats.MonsterBattleType = OGBattleStats.MonsterBattleType;

        SetMaxHP();
    }

    public void FeedMonster(Food f)
    {
        if (Player.Instance.playerInventory.GetAmountOfFood(f.Name) > 0)
        {
            f.Feed(this.battleStats.MonsterStats);
            Player.Instance.playerInventory.RemoveOneFood(f.Name);
        }
    }

    public void SetMaxHP()
    {
        this.battleStats.MonsterStats.CurrentHP = this.battleStats.MonsterStats.MaxHP;
    }
}
