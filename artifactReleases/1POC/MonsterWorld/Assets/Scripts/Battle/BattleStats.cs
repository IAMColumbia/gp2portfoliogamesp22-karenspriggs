using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStats : MonoBehaviour
{
    private MoveSet monsterMoveSet;
    private BattleType monsterBattleType;
    private Stats monsterStats;

    public MoveSet MonsterMoveSet
    {
        get { return monsterMoveSet; }
    }

    public BattleType MonsterBattleType { get { return monsterBattleType; } }

    public Stats MonsterStats { get { return monsterStats; } }

    public string Name;

    public BattleStats()
    {
        this.monsterMoveSet = new MoveSet();
        this.monsterBattleType = BattleTypeDatabase.FlowerType;
        Debug.Log(monsterBattleType.Name);
        this.monsterStats = new Stats(20, 20, 2, 2, 2);
    }

    private void Start()
    {
        this.monsterMoveSet = new MoveSet();
        this.monsterBattleType = BattleTypeDatabase.FlowerType;
        Debug.Log(monsterBattleType.Name);
        this.monsterStats = new Stats(20, 20, 2, 2, 2);
    }

    // This is in here because it can have access to the battle stats of its own monster
    public int DetermineDamage(Move move, BattleStats otherMonster)
    {
        int basedamage = move.Power * monsterStats.Attack;
        int damage = basedamage;

        // Check if the type of the move is good or bad against the type of the other mon
        if (move.MoveType == otherMonster.monsterBattleType.TypeWeakAgainst)
        {
            //Debug.Log("Type weak against");
            //Debug.Log(move.MoveType);
            //Debug.Log(otherMonster.monsterBattleType.TypeWeakAgainst);
            damage *= 2;
        } 
        
        if (move.MoveType == otherMonster.monsterBattleType.TypeGoodAgainst)
        {
            damage /= 2;
        }

        return damage;
    }
}
