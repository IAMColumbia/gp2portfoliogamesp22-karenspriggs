using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMonStore : MonoBehaviour
{
    MonPlantStore monPlantStore;

    void Start()
    {
        monPlantStore = new MonPlantStore();
    }

    public void BuySunflowerLion()
    {
        monPlantStore.SellMonPlant("SunflowerLion");
    }

    public void BuyAdvodoggo()
    {
        monPlantStore.SellMonPlant("Advodoggo");
    }

    public void BuyStrawbunny()
    {
        monPlantStore.SellMonPlant("Strawbunny");
    }

    public void BuyRaccorn()
    {
        monPlantStore.SellMonPlant("Raccorn");
    }
}
