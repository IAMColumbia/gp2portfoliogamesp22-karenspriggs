using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMonster : BattleStats
{
    int moveIndex;
    public Move MoveChosen;
    
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
            moveToUse = this.MonsterMoveSet.Move1;
        }

        if (moveIndex == 1)
        {
            moveToUse = this.MonsterMoveSet.Move2;
        }

        if (moveIndex == 2)
        {
            moveToUse = this.MonsterMoveSet.Move3;
        }

        if (moveIndex == 3)
        {
            moveToUse = this.MonsterMoveSet.Move4;
        }

        return moveToUse;
    }
}
