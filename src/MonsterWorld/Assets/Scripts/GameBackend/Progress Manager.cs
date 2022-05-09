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

        winIndex = 0;

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

        if (winIndex < statKeys.Count)
        {
            winIndex++;
        }
    }

    public Monster GetEnemyMonster()
    {
        Debug.Log(MonsterFactory.Instance.GetMon(statKeys[winIndex]).battleStats.Name);
        return MonsterFactory.Instance.GetMon(statKeys[winIndex]);
    }
}
