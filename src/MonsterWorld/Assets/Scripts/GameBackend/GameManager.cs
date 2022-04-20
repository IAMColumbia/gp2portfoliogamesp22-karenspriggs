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

    public MonsterPlantPlot[] monsterPlantPlots;
    public FoodPlantPlot[] foodPlantPlots;
    public int plotSize;

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

        farmManager = new FarmManager(plotSize, monsterPlantPlots, foodPlantPlots);

        uiManager = new UIManager(monPlantShopUI, foodPlantShopUI);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            farmManager.plotHandler.FillFirstFoodPlot(FoodPlantFactory.Instance.GetFoodPlant("HP Berry"));
        }
    }

    public void TurnOnBattleState()
    {
        gameStateManager.SetBattleState();
    }

    public void TurnOnFarmState()
    {
        gameStateManager.SetFarmingState();
    }

    public void EnterMonShop()
    {
        uiManager.EnterMonShop();
        uiManager.ExitFoodShop();
    }

    public void EnterFoodShop()
    {
        uiManager.EnterFoodShop();
        uiManager.ExitMonShop();
    }
}
