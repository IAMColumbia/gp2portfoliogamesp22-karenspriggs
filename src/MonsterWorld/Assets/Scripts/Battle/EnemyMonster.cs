using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMonster 
{
    int moveIndex;

    public BattleStats battleStats;
    public Move MoveChosen;
    public string statsKey;

    public Monster enemyMonster;

    public EnemyMonster()
    {
        this.enemyMonster = new Monster();
        this.enemyMonster = GameManager.SharedInstance.progressManager.GetEnemyMonster();
    }

    public void DetermineMove()
    {
        moveIndex = Random.Range(0, 4);
    }

    public Move UseMove()
    {
        DetermineMove();

        Move moveToUse = new Move();

        if (moveIndex == 0)
        {
            moveToUse = this.enemyMonster.battleStats.MonsterMoveSet.Move1;
        }

        if (moveIndex == 1)
        {
            moveToUse = this.enemyMonster.battleStats.MonsterMoveSet.Move2;
        }

        if (moveIndex == 2)
        {
            moveToUse = this.enemyMonster.battleStats.MonsterMoveSet.Move3;
        }

        if (moveIndex == 3)
        {
            moveToUse = this.enemyMonster.battleStats.MonsterMoveSet.Move4;
        }

        return moveToUse;
    }

    public void UpdateMonster()
    {
        this.enemyMonster = GameManager.SharedInstance.progressManager.GetEnemyMonster();
        Debug.Log(this.enemyMonster.battleStats.Name);
    }
}
