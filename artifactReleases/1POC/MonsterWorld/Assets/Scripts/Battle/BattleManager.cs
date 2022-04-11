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
    public UnityMonster playerMonster;
    
    public EnemyMonster enemyMonster;

    public Battler playerBattler;
    public Battler enemyBattler;

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
        int damage = playerMonster.monster.battleStats.DetermineDamage(playerMonster.monster.battleStats.MonsterMoveSet.Move1, enemyMonster.battleStats);
        int newEnemyHP = ApplyDamage(damage, enemyMonster.battleStats);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.monster.battleStats.MonsterMoveSet.Move1.Name);
        EnemyTurn();
    }

    public void UseMoveTwo()
    {
        int damage = playerMonster.monster.battleStats.DetermineDamage(playerMonster.monster.battleStats.MonsterMoveSet.Move2, enemyMonster.battleStats);
        int newEnemyHP = ApplyDamage(damage, enemyMonster.battleStats);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.monster.battleStats.MonsterMoveSet.Move2.Name);
        EnemyTurn();
    }

    public void UseMoveThree()
    {
        int damage = playerMonster.monster.battleStats.DetermineDamage(playerMonster.monster.battleStats.MonsterMoveSet.Move3, enemyMonster.battleStats);
        int newEnemyHP = ApplyDamage(damage, enemyMonster.battleStats);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.monster.battleStats.MonsterMoveSet.Move3.Name);
        EnemyTurn(); 
    }

    public void UseMoveFour()
    {
        int damage = playerMonster.monster.battleStats.DetermineDamage(playerMonster.monster.battleStats.MonsterMoveSet.Move4, enemyMonster.battleStats);
        int newEnemyHP = ApplyDamage(damage, enemyMonster.battleStats);

        if (newEnemyHP < 0)
        {
            newEnemyHP = 0;
        }

        battleUI.UseMove(damage, newEnemyHP, playerMonster.monster.battleStats.MonsterMoveSet.Move4.Name);
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

        int damage = enemyMonster.battleStats.DetermineDamage(enemyMove, playerMonster.monster.battleStats);
        int newPlayerHP = ApplyDamage(damage, playerMonster.monster.battleStats);

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
        playerMonster.monster.battleStats.MonsterStats.CurrentHP = playerMonster.monster.battleStats.MonsterStats.MaxHP;
        enemyMonster.battleStats.MonsterStats.CurrentHP = enemyMonster.battleStats.MonsterStats.MaxHP;
        enemyMonster.battleStats.MonsterStats.CurrentHP = enemyMonster.battleStats.MonsterStats.MaxHP;
    }
}
