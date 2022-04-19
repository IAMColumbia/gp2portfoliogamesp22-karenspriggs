using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStorage
{
    public List<Monster> monstersInStorage;

    public MonsterStorage()
    {
        monstersInStorage = new List<Monster>();
    }

    // Method to add a monster to player inventory
    // Method to remove monster from player inventory and then add to storage

    void AddMonsterToPlayerTeam(Monster m)
    {
        if (Player.Instance.playerInventory.CanAddMonster())
        {
            Player.Instance.playerInventory.AddMonster(m);
        }
    }
}
