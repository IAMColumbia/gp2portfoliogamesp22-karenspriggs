using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager 
{
    public bool canBuyTomatoad;
    public bool canBuyGiraffodil;
    public bool canBuyPumpkitty;

    int winIndex;
    List<string> statKeys;

    public ProgressManager()
    {
        canBuyTomatoad = false;
        canBuyGiraffodil = false;
        canBuyPumpkitty = false;

        statKeys = new List<string>() { "BossTomatoad", "BossGiraffodil", "BossPumpkitty" };
    }

    public void UpdateCanBuy()
    {
        if (!canBuyTomatoad)
        {
            canBuyTomatoad = true;
        } else
        {
            if (!canBuyGiraffodil)
            {
                canBuyGiraffodil = true;
            } else
            {
                if (!canBuyPumpkitty)
                {
                    canBuyPumpkitty = true;
                }
            }
        }
    }

    public Monster GetEnemyMonster()
    {
        return MonsterFactory.Instance.GetMon(statKeys[winIndex]);
    }
}
