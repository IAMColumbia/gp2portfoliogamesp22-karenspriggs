using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterMenuUI : MonoBehaviour
{
    public Text monster1name;
    public Text monster1stats;
    public Text monster2name;
    public Text monster2stats;
    public Text monster3name;
    public Text monster3stats;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Player.Instance.playerInventory);
        Debug.Log(Player.Instance.playerInventory.PrintMonsterName(0));
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateText()
    {
        Debug.Log(Player.Instance.playerInventory.PrintMonsterName(0));

        monster1name.text = Player.Instance.playerInventory.PrintMonsterName(0);
        monster2name.text = Player.Instance.playerInventory.PrintMonsterName(1);
        monster3name.text = Player.Instance.playerInventory.PrintMonsterName(2);

        monster1stats.text = Player.Instance.playerInventory.PrintMonsterInfo(0);
        monster2stats.text = Player.Instance.playerInventory.PrintMonsterInfo(1);
        monster3stats.text = Player.Instance.playerInventory.PrintMonsterInfo(2);
    }
}
