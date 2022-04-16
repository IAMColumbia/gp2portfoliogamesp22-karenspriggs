using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> battleObjects;
    public List<GameObject> farmingObjects;

    BattleManager battleManager;
    FarmManager farmManager;
    GameStateManager gameStateManager;
    UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        gameStateManager = new GameStateManager();
        gameStateManager.battleGameObjects = battleObjects;
        gameStateManager.farmingGameObjects = farmingObjects;
        gameStateManager.SetFarmingState();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnOnBattleState()
    {
        gameStateManager.SetBattleState();
    }

    public void TurnOnFarmState()
    {
        gameStateManager.SetFarmingState();
    }
}
