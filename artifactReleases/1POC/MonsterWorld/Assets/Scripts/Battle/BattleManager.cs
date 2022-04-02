using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState
{
    Start,
    PlayerTurn,
    EnemyTurn,
    Win,
    Loss
}

public class BattleManager : MonoBehaviour
{
    public BattleStats playerMonster;
    //public BattleStats enemyMonster;
    public EnemyMonster enemyMonster;

    public BattleUIManager battleUI;
    public BattleState battleState;

    private void Start()
    {
        SetupUI();
        this.battleState = BattleState.Start;
    }

    // Methods for player using moves via buttons in UI
    public void UseMoveOne()
    {
        int damage = playerMonster.DetermineDamage(playerMonster.MonsterMoveSet.Move1, enemyMonster);
        int newEnemyHP = ApplyDamage(damage, enemyMonster);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.MonsterMoveSet.Move1.Name);
        EnemyTurn();
    }

    public void UseMoveTwo()
    {
        int damage = playerMonster.DetermineDamage(playerMonster.MonsterMoveSet.Move2, enemyMonster);
        int newEnemyHP = ApplyDamage(damage, enemyMonster);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.MonsterMoveSet.Move2.Name);
        EnemyTurn();
    }

    public void UseMoveThree()
    {
        int damage = playerMonster.DetermineDamage(playerMonster.MonsterMoveSet.Move3, enemyMonster);
        int newEnemyHP = ApplyDamage(damage, enemyMonster);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.MonsterMoveSet.Move3.Name);
        EnemyTurn(); 
    }

    public void UseMoveFour()
    {
        int damage = playerMonster.DetermineDamage(playerMonster.MonsterMoveSet.Move4, enemyMonster);
        int newEnemyHP = ApplyDamage(damage, enemyMonster);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.MonsterMoveSet.Move4.Name);
        EnemyTurn();
    }

    // Method to apply damage to other monster
    public int ApplyDamage(int damage, BattleStats otherMonster)
    {
        otherMonster.MonsterStats.CurrentHP -= damage;

        return otherMonster.MonsterStats.CurrentHP;
    }

    void EnemyTurn()
    {
        Move enemyMove = enemyMonster.UseMove();

        int damage = enemyMonster.DetermineDamage(enemyMove, playerMonster);
        int newPlayerHP = ApplyDamage(damage, playerMonster);

        if (newPlayerHP < 0)
        {
            newPlayerHP = 0;
        }

        battleUI.UseEnemyMove(damage, newPlayerHP, enemyMove.Name);
    }

    void SetupUI()
    {
        battleUI.ConnectBattleManager(this);
    }

    public void ResetHPForTesting()
    {
        playerMonster.MonsterStats.CurrentHP = playerMonster.MonsterStats.MaxHP;
        enemyMonster.MonsterStats.CurrentHP = enemyMonster.MonsterStats.MaxHP;
    }
}
