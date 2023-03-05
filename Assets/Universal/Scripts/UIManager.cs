using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using DG.Tweening;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : GameBehaviour<UIManager>
{
   
    private TextMeshProUGUI wrenchText;

   
    void Start()
    {
       
        wrenchText = GetComponent<TextMeshProUGUI>();
        //scoreText.text = score.ToString();
    }
   
    public void UpdateWrenchText(PlayerInventory playerInventory)
    {
        wrenchText.text = playerInventory.NumberOfWrenches.ToString();
    }
    //public TMP_Text scoreText;
    ////public TMP_Text timerText;
    //int score = 0;
    //int scoreBonus = 50;
    //public Ease scoreEase;
    //// Start is called before the first frame update

    ////private void Update()
    ////{
    ////    timerText.text = _TIMER.Gettime().ToString("F3");
    ////}
    //public void TweenScore()
    //{
    //    DOTween.To(() => score, x => score = x, score + scoreBonus, 1).SetEase(scoreEase).OnUpdate(() =>
    //    {
    //        scoreText.text = "Score: " + score.ToString();
    //    }); 
    //}
}
