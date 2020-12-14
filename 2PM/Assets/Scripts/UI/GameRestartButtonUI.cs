using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameRestartButtonUI : MonoBehaviour
{
    public void Clicked()
    {
        EventManager.Emit("game_started", null);
    }
}