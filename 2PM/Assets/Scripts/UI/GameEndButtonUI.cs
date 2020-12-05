using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndButtonUI : MonoBehaviour
{
    public void Clicked()
    {
        EventManager.Emit("game_ended", null);
    }
}
