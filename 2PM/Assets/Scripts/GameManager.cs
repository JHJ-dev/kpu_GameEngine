using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBehaviour<GameManager>
{
    public GameState state;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        EventManager.On("game_started", OnGameStart);
        EventManager.On("game_paused", OnGamePause);
        EventManager.On("game_ended", OnGameEnd);
    }
    
    private void OnGameStart(object obj)
    {
        state = GameState.Playing;
    }
    
    private void OnGamePause(object obj)
    {
        state = GameState.Paused;
    }
    
    private void OnGameEnd(object obj)
    {
        state = GameState.Ended;
    }

}
