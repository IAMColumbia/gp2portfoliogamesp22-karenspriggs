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
    //public UnityMonster playerMonster;
    public EnemyMonster enemyBattler;

    public Battler playerBattler;
    //public Battler enemyBattler;

    public BattleUIManager battleUI;
    public BattleState battleState;

    public int playerMonIndex;

    bool playerWon = false;

    private void Start()
    {
        
    }

    private void Awake()
    {
        playerMonIndex = 0;
        playerBattler = new Battler();
        enemyBattler = new EnemyMonster();
        this.battleState = BattleState.Start;
    }

    public void SetMonster()
    {
        if (playerMonIndex < Player.Instance.playerInventory.teamSize)
        {
            playerBattler.monsterBattler = Player.Instance.playerInventory.GetBattler(playerMonIndex);
        }

        playerWon = false;

        SetupUI();
    }

    // Methods for player using moves via buttons in UI
    public void UseMoveOne()
    {
        if (playerBattler.monsterBattler.battleStats.MonsterStats.CurrentHP > 0)
        {
            int damage = playerBattler.monsterBattler.battleStats.DetermineDamage(playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move1, enemyBattler.enemyMonster.battleStats);
            int newEnemyHP = ApplyDamage(damage, enemyBattler.enemyMonster.battleStats);

            if (newEnemyHP <= 0)
            {
                newEnemyHP = 0;
                GameManager.SharedInstance.progressManager.UpdateCanBuy();
                playerWon = true;
                battleUI.ShowWin();
            }

            battleUI.UseMove(damage, newEnemyHP, playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move1.Name);
            EnemyTurn();

            if (Player.Instance.playerInventory.CheckIfLost() && !playerWon)
            {
                battleUI.ShowLoss();
            }
        }
    }

    public void UseMoveTwo()
    {
        if (playerBattler.monsterBattler.battleStats.MonsterStats.CurrentHP > 0)
        {
            int damage = playerBattler.monsterBattler.battleStats.DetermineDamage(playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move2, enemyBattler.enemyMonster.battleStats);
            int newEnemyHP = ApplyDamage(damage, enemyBattler.enemyMonster.battleStats);

            if (newEnemyHP <= 0)
            {
                newEnemyHP = 0;
                GameManager.SharedInstance.progressManager.UpdateCanBuy();
                playerWon = true;
                battleUI.ShowWin();
            }

            battleUI.UseMove(damage, newEnemyHP, playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move2.Name);
            EnemyTurn();

            if (Player.Instance.playerInventory.CheckIfLost() && !playerWon)
            {
                battleUI.ShowLoss();
            }
        }
    }

    public void UseMoveThree()
    {
        if (playerBattler.monsterBattler.battleStats.MonsterStats.CurrentHP > 0)
        {
            int damage = playerBattler.monsterBattler.battleStats.DetermineDamage(playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move3, enemyBattler.enemyMonster.battleStats);
            int newEnemyHP = ApplyDamage(damage, enemyBattler.enemyMonster.battleStats);

            if (newEnemyHP <= 0)
            {
                newEnemyHP = 0;
                GameManager.SharedInstance.progressManager.UpdateCanBuy();
                playerWon = true;
                battleUI.ShowWin();
            }

            battleUI.UseMove(damage, newEnemyHP, playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move3.Name);
            EnemyTurn();

            if (Player.Instance.playerInventory.CheckIfLost() && !playerWon)
            {
                battleUI.ShowLoss();
            }
        }
    }

    public void UseMoveFour()
    {
        if (playerBattler.monsterBattler.battleStats.MonsterStats.CurrentHP > 0)
        {
            int damage = playerBattler.monsterBattler.battleStats.DetermineDamage(playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move4, enemyBattler.enemyMonster.battleStats);
            int newEnemyHP = ApplyDamage(damage, enemyBattler.enemyMonster.battleStats);

            if (newEnemyHP <= 0)
            {
                newEnemyHP = 0;
                playerWon = true;
                GameManager.SharedInstance.progressManager.UpdateCanBuy();
                battleUI.ShowWin();
            }

            battleUI.UseMove(damage, newEnemyHP, playerBattler.monsterBattler.battleStats.MonsterMoveSet.Move4.Name);
            EnemyTurn();

            if (Player.Instance.playerInventory.CheckIfLost() && !playerWon)
            {
                battleUI.ShowLoss();
            }
        }
    }

    // Method to apply damage to other monster
    public int ApplyDamage(int damage, BattleStats otherMonster)
    {
        otherMonster.MonsterStats.CurrentHP -= damage;

        return otherMonster.MonsterStats.CurrentHP;
    }

    void EnemyTurn()
    {
        Move enemyMove = enemyBattler.UseMove();

        int damage = enemyBattler.enemyMonster.battleStats.DetermineDamage(enemyMove, playerBattler.monsterBattler.battleStats);
        int newPlayerHP = ApplyDamage(damage, playerBattler.monsterBattler.battleStats);

        if (newPlayerHP <= 0)
        {
            newPlayerHP = 0;
            this.playerBattler.monsterBattler.battleStats.MonsterStats.CurrentHP = 0;
        }

        battleUI.UseEnemyMove(damage, newPlayerHP, enemyMove.Name);
    }

    void SetupUI()
    {
        battleUI.ConnectBattleManager(this);
    }

    public void ResetHPForTesting()
    {
        playerBattler.monsterBattler.battleStats.MonsterStats.CurrentHP = playerBattler.monsterBattler.battleStats.MonsterStats.MaxHP;
        enemyBattler.enemyMonster.battleStats.MonsterStats.CurrentHP = enemyBattler.enemyMonster.battleStats.MonsterStats.MaxHP;
        //SetupUI();
    }

    public void ResetEnemyHP()
    {
        enemyBattler = new EnemyMonster();
        enemyBattler.enemyMonster.battleStats.MonsterStats.CurrentHP = enemyBattler.enemyMonster.battleStats.MonsterStats.MaxHP;
    }
}
