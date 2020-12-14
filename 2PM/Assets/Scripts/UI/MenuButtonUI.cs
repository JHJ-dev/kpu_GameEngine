﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonUI : SingletonBehaviour<GameManager>
{
    private void Start()
    {
        gameObject.SetActive(false);
        EventManager.On("game_started", Show);
        EventManager.On("game_paused", Hide);
        EventManager.On("game_ended", Hide);
    }

    private void Show(object obj) => gameObject.SetActive(true);

    private void Hide(object obj) => gameObject.SetActive(false);

    public void Clicked()
    {
        EventManager.Emit("game_paused", null);
    }
}
