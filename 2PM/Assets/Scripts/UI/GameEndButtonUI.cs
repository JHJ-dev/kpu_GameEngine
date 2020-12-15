using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameEndButtonUI : MonoBehaviour
{
    public void Clicked()
    {
        EventManager.Emit("game_ended", null);
        Application.Quit();
    }
}