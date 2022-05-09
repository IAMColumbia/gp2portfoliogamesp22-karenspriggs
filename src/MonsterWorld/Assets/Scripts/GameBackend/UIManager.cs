using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    GameObject MonPlantShopUIPanel;
    GameObject FoodPlantShopUIPanel;

    UnityMonStore monsterStore;
    UnityFoodStore foodStore;
    MonsterStorageUI storageUI;

    public bool canOpenMonMenu;

    //public UIManager(GameObject monplantUI, GameObject foodplantUI)
    //{
    //    this.MonPlantShopUIPanel = monplantUI;
    //    this.FoodPlantShopUIPanel = foodplantUI;

    //    this.MonPlantShopUIPanel.gameObject.SetActive(false);
    //    this.FoodPlantShopUIPanel.gameObject.SetActive(false);
    //}

    public UIManager(UnityMonStore monsterStore, UnityFoodStore foodStore, MonsterStorageUI storageUI)
    {
        this.monsterStore = monsterStore;
        this.foodStore = foodStore;
        this.storageUI = storageUI;

        this.monsterStore.HideSelf();
        this.foodStore.HideSelf();
        this.storageUI.HideSelf();

        canOpenMonMenu = true;
    }

    public void EnterFoodShop()
    {
        Player.Instance.canMove = false;
        foodStore.ShowSelf();
    }

    public void ExitFoodShop()
    {
        Player.Instance.canMove = true;
        foodStore.HideSelf();
    } 

    public void EnterMonShop()
    {
        //this.MonPlantShopUIPanel.gameObject.SetActive(true);
        Player.Instance.canMove = false;
        monsterStore.ShowSelf();
    }

    public void ExitMonShop()
    {
        //this.MonPlantShopUIPanel.gameObject.SetActive(false);
        Player.Instance.canMove = true;
        monsterStore.HideSelf();
    }

    public void HideAllUI()
    {
        monsterStore.HideSelf();
        foodStore.HideSelf();
        storageUI.HideSelf();
    }
}
