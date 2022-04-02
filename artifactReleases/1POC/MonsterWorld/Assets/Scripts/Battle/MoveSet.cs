using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSet
{
    private Move move1;
    private Move move2;
    private Move move3;
    private Move move4;

    public Move Move1
    {
        get { return move1; }
    }
    public Move Move2
    {
        get { return move2; }
    }
    public Move Move3
    {
        get { return move3; }
    }
    public Move Move4
    {
        get { return move4; }
    }

    public MoveSet()
    {
        move1 = new Move("Veggie Bite", 4, BattleTypeDatabase.VeggieType);
        move2 = new Move("Fruit Slash", 4, BattleTypeDatabase.FruitType);
        move3 = new Move("Flower Bite", 4, BattleTypeDatabase.FlowerType);
        move4 = new Move("Flower Slash", 2, BattleTypeDatabase.FlowerType);
    }
}
