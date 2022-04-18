using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> battleObjects;
    public List<GameObject> farmingObjects;
    public GameObject monPlantShopUI;
    public GameObject foodPlantShopUI;

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

        uiManager = new UIManager(monPlantShopUI, foodPlantShopUI);
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
