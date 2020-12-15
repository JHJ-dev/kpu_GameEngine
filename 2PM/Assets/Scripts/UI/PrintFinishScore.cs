using System;
using UnityEngine;
using UnityEngine.UI;

public class PrintFinishScore : MonoBehaviour
{
    private Text _text;
    public int score;
    public PrintScore pScore;

    private void Start()
    {
        pScore = GameObject.Find("Score").GetComponent<PrintScore>();
        _text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        if (GameManager.Instance.state == GameState.Initialized || GameManager.Instance.state == GameState.Playing || GameManager.Instance.state == GameState.Paused)
        {
            _text.text = "";
        }
        if (GameManager.Instance.state == GameState.Ended)
        {
            _text.text = $"{pScore.score}";
        }
    }
}
