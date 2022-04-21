using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    GameObject MonPlantShopUIPanel;
    GameObject FoodPlantShopUIPanel;

    public UIManager(GameObject monplantUI, GameObject foodplantUI)
    {
        this.MonPlantShopUIPanel = monplantUI;
        this.FoodPlantShopUIPanel = foodplantUI;

        this.MonPlantShopUIPanel.gameObject.SetActive(false);
        //this.FoodPlantShopUIPanel.gameObject.SetActive(false);
    }

    public void EnterFoodShop()
    {
        this.FoodPlantShopUIPanel.gameObject.SetActive(true);
    }

    public void ExitFoodShop()
    {
        this.FoodPlantShopUIPanel.gameObject.SetActive(false);
    } 

    public void EnterMonShop()
    {
        this.MonPlantShopUIPanel.gameObject.SetActive(true);
    }

    public void ExitMonShop()
    {
        this.MonPlantShopUIPanel.gameObject.SetActive(false);
    }
}
