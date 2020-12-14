using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonUI : SingletonBehaviour<GameManager>
{
    public GameState state;
    
    private void Start()
    {
        EventManager.On("game_started", OnGameStart);
        EventManager.On("game_paused", OnGamePause);
        gameObject.SetActive(false);
    }
    
    private void OnGameStart(object obj)
    {
        gameObject.SetActive(true);
    }
    
    private void OnGamePause(object obj)
    {
        gameObject.SetActive(false);
    }

    public void Clicked()
    {
        EventManager.Emit("game_paused", null);
    }
}
