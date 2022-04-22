using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStorage
{
    private List<Monster> monstersInStorage;

    public MonsterStorage()
    {
        monstersInStorage = new List<Monster>();
    }

    // Method to add a monster to player inventory
    // Method to remove monster from player inventory and then add to storage\

    public void AddMonsterToStorage(Monster m)
    {
        monstersInStorage.Add(m);
    }

    public string ListMonstersInStorage()
    {
        string list = "";

        foreach (Monster m in monstersInStorage)
        {
            list += $"{m.battleStats.Name}\n";
        }

        return list;
    }

    void AddMonsterToPlayerTeam(Monster m)
    {
        if (Player.Instance.playerInventory.CanAddMonster())
        {
            Player.Instance.playerInventory.AddMonster(m);
        }
    }
}
