using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBehaviour<GameManager>
{
    public GameState state;

    private void Start()
    {
        EventManager.On("game_started", OnGameStart);
    }

    private void OnGameStart(object obj)
    {
        state = GameState.Playing;
    }
}
