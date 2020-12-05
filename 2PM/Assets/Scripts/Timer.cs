using System;
using UnityEngine;
using UnityEngine.UI;

namespace Timer
{
    public class Timer : MonoBehaviour
    {
        private Text _text;

        private float _time = 180.0f;
        private bool _active;

        //public float CurrentTime => _time;

        private void Awake()
        {
            _active = true;
            _text = GetComponent<Text>();
        }

        void Update()
        {
            if (_active)
                _time -= Time.deltaTime;

            var timeSpan = new TimeSpan(0, 0, 0, 0, (int)_time * 1000);
            _text.text = $"{timeSpan.Minutes:00}:{timeSpan.Seconds:00}";
        }
    }
}