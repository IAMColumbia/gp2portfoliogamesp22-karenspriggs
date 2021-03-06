using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager SharedInstance;

    public List<GameObject> battleObjects;
    public List<GameObject> farmingObjects;

    public UnityMonStore monsterStore;
    public UnityFoodStore foodStore;
    public MonsterStorageUI monStorageUI;

    public MonsterPlantPlot[] monsterPlantPlots;
    public FoodPlantPlot[] foodPlantPlots;
    public int plotSize;

    public BattleManager battleManager;
    public FarmManager farmManager;
    public GameStateManager gameStateManager;
    public UIManager uiManager;
    public ProgressManager progressManager;

    // Start is called before the first frame update
    void Start()
    {
        gameStateManager = new GameStateManager();
        gameStateManager.battleGameObjects = battleObjects;
        gameStateManager.farmingGameObjects = farmingObjects;
        gameStateManager.SetFarmingState();

        farmManager = new FarmManager(plotSize, monsterPlantPlots, foodPlantPlots);

        uiManager = new UIManager(monsterStore, foodStore, monStorageUI);

        progressManager = new ProgressManager();

        if (SharedInstance == null)
        {
            SharedInstance = this;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //farmManager.plotHandler.FillFirstFoodPlot(FoodPlantFactory.Instance.GetFoodPlant("HP Berry"));
        }
    }

    public void TurnOnBattleState()
    {
        gameStateManager.SetBattleState();
        battleManager.ResetEnemyHP();
        battleManager.SetMonster();
    }

    public void TurnOnFarmState()
    {
        gameStateManager.SetFarmingState();
    }

    public void EnterMonShop()
    {
        Player.Instance.canMove = false;
        uiManager.EnterMonShop();
    }

    public void EnterFoodShop()
    {
        Player.Instance.canMove = false;
        uiManager.EnterFoodShop();
    }
}
