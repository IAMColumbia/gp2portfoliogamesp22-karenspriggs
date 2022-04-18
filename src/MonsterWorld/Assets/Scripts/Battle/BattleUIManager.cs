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
        this.playerMonName.text = battleManager.playerMonster.monster.battleStats.Name;
        this.enemyMonName.text = $"Enemy {battleManager.enemyMonster.battleStats.Name}";

        this.playerMonHP.text = $"{battleManager.playerMonster.monster.battleStats.MonsterStats.CurrentHP} / {battleManager.playerMonster.monster.battleStats.MonsterStats.MaxHP}";
        this.enemyMonHP.text = $"{battleManager.enemyMonster.battleStats.MonsterStats.CurrentHP} / {battleManager.enemyMonster.battleStats.MonsterStats.MaxHP}";

        this.playerMonType.text = $"{battleManager.playerMonster.monster.battleStats.MonsterBattleType.Name} Type";
        this.enemyMonType.text = $"{battleManager.enemyMonster.battleStats.MonsterBattleType.Name} Type";

        SetUpButtons();
    }

    public void SetUpButtons()
    {
        move1ButtonText.text = battleManager.playerMonster.monster.battleStats.MonsterMoveSet.Move1.Name;
        move2ButtonText.text = battleManager.playerMonster.monster.battleStats.MonsterMoveSet.Move2.Name;
        move3ButtonText.text = battleManager.playerMonster.monster.battleStats.MonsterMoveSet.Move3.Name;
        move4ButtonText.text = battleManager.playerMonster.monster.battleStats.MonsterMoveSet.Move4.Name;
    }

    public void UseMove(int damage, int newHP, string moveName)
    {
        this.enemyMonHP.text = $"{newHP} / {battleManager.enemyMonster.battleStats.MonsterStats.MaxHP}";
    }

    public void UseEnemyMove(int damage, int newHP, string moveName)
    {
        this.playerMonHP.text = $"{newHP} / {battleManager.enemyMonster.battleStats.MonsterStats.MaxHP}";
        this.enemyMoveText.text = $"Enemy {battleManager.enemyMonster.battleStats.Name} used {moveName}!";
    }

    public void ResetHP()
    {
        this.battleManager.ResetHPForTesting();
        this.playerMonHP.text = $"{battleManager.playerMonster.monster.battleStats.MonsterStats.CurrentHP} / {battleManager.playerMonster.monster.battleStats.MonsterStats.MaxHP}";
        this.enemyMonHP.text = $"{battleManager.enemyMonster.battleStats.MonsterStats.CurrentHP} / {battleManager.enemyMonster.battleStats.MonsterStats.MaxHP}";
    }
}
