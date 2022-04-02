using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUIManager : MonoBehaviour
{
    public Text move1ButtonText;
    public Text move2ButtonText;
    public Text move3ButtonText;
    public Text move4ButtonText;

    public Text playerMonName;
    public Text enemyMonName;
    public Text playerMonHP;
    public Text enemyMonHP;
    public Text playerMonType;
    public Text enemyMonType;

    public Text enemyMoveText;

    public BattleManager battleManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConnectBattleManager(BattleManager battleManager)
    {
        this.battleManager = battleManager;
        SetupUI();
    }

    public void SetupUI()
    {
        this.playerMonName.text = battleManager.playerMonster.Name;
        this.enemyMonName.text = battleManager.enemyMonster.Name;

        this.playerMonHP.text = $"{battleManager.playerMonster.MonsterStats.CurrentHP} / {battleManager.playerMonster.MonsterStats.MaxHP}";
        this.enemyMonHP.text = $"{battleManager.enemyMonster.MonsterStats.CurrentHP} / {battleManager.enemyMonster.MonsterStats.MaxHP}";

        this.playerMonType.text = $"{battleManager.playerMonster.MonsterBattleType.Name} Type";
        this.enemyMonType.text = $"{battleManager.enemyMonster.MonsterBattleType.Name} Type";

        SetUpButtons();
    }

    public void SetUpButtons()
    {
        move1ButtonText.text = battleManager.playerMonster.MonsterMoveSet.Move1.Name;
        move2ButtonText.text = battleManager.playerMonster.MonsterMoveSet.Move2.Name;
        move3ButtonText.text = battleManager.playerMonster.MonsterMoveSet.Move3.Name;
        move4ButtonText.text = battleManager.playerMonster.MonsterMoveSet.Move4.Name;
    }

    public void UseMove(int damage, int newHP, string moveName)
    {
        this.enemyMonHP.text = $"{newHP} / {battleManager.enemyMonster.MonsterStats.MaxHP}";
    }

    public void UseEnemyMove(int damage, int newHP, string moveName)
    {
        this.playerMonHP.text = $"{newHP} / {battleManager.enemyMonster.MonsterStats.MaxHP}";
        this.enemyMoveText.text = $"Enemy {battleManager.enemyMonster.Name} used {moveName}!";
    }

    public void ResetHP()
    {
        this.battleManager.ResetHPForTesting();
        this.playerMonHP.text = $"{battleManager.playerMonster.MonsterStats.CurrentHP} / {battleManager.playerMonster.MonsterStats.MaxHP}";
        this.enemyMonHP.text = $"{battleManager.enemyMonster.MonsterStats.CurrentHP} / {battleManager.enemyMonster.MonsterStats.MaxHP}";
    }
}
