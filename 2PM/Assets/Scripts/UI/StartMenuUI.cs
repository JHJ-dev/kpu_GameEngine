using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuUI : MonoBehaviour
{
    void Start()
    {
        EventManager.On("game_started", Hide);
        EventManager.On("game_paused", Show);
        EventManager.On("game_ended", Show);
    }

    private void Show(object obj) => gameObject.SetActive(true);

    private void Hide(object obj) => gameObject.SetActive(false);
}
