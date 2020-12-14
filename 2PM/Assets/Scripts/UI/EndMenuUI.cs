using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuUI : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        EventManager.On("game_started", Hide);
        EventManager.On("game_paused", Hide);
        EventManager.On("game_ended", Show);
    }

    private void Show(object obj) => gameObject.SetActive(true);

    private void Hide(object obj) => gameObject.SetActive(false);
}