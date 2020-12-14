using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        EventManager.On("game_started", Show);
        EventManager.On("game_paused", Hide);
        EventManager.On("game_ended", Hide);
    }

    private void Show(object obj) => gameObject.SetActive(true);

    private void Hide(object obj) => gameObject.SetActive(false);
}
