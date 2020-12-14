using System;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    private Text _text;
    public int score;
    //PizzaControll pizza;

    private void Start()
    {
        _text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        if (GameManager.Instance.state == GameState.Initialized)
        {
            _text.text = "";
        }

        if (GameManager.Instance.state == GameState.Playing)
        {
            _text.text = $"점수:{score}";
        }
    }
}
