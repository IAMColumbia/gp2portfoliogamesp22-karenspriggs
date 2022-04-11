using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates
{
    Farming,
    Battling,
    Paused
}

public class GameStateManager
{
    public GameStates currentGameState;

    public GameStateManager()
    {
        this.currentGameState = GameStates.Farming;
    }
}
