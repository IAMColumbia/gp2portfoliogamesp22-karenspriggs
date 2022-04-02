using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public BattleStats battleStats;

    public Monster()
    {
        battleStats = new BattleStats();
    }

}
