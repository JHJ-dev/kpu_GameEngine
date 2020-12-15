using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text _text;

    private float _time = 10.0f;
    private bool _active;

    private void Start()
    {
        gameObject.SetActive(false);
        EventManager.On("game_started", Show);
        EventManager.On("game_paused", Hide);
        EventManager.On("game_ended", Hide);
    }

    private void Awake()
    {
        _active = true;
        _text = GetComponent<Text>();
    }

    void Update()
    {
        if (GameManager.Instance.state == GameState.Playing)
        {
            if (_active)
                _time -= Time.deltaTime;
            if (_time <= 0.0f)
                EventManager.Emit("game_ended", null);

            var timeSpan = new TimeSpan(0, 0, 0, 0, (int) _time * 1000);
            _text.text = $"{timeSpan.Minutes:00}:{timeSpan.Seconds:00}";
        }
    }
        
    private void Show(object obj) => gameObject.SetActive(true);

    private void Hide(object obj) => gameObject.SetActive(false);
}