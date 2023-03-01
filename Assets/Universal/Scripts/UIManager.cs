using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class UIManager : GameBehaviour<UIManager>
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    int score = 0;
    int scoreBonus = 50;
    public Ease scoreEase;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }
    private void Update()
    {
        timerText.text = _TIMER.Gettime().ToString("F3");
    }
    public void TweenScore()
    {
        DOTween.To(() => score, x => score = x, score + scoreBonus, 1).SetEase(scoreEase).OnUpdate(() =>
        {
            scoreText.text = "Score: " + score.ToString();
        }); 
    }
}
