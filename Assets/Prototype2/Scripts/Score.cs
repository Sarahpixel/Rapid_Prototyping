using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    //public int score = 0;

   
    //public TextMeshProUGUI highScoreText;
    //public TextMeshProUGUI finalScoreText;

    //public Player player_Script;
    //private void Update()
    //{
    //    //scoreText.text = player_Script.score.ToString();
    //}
    //public void UpdateHighScore()
    //{
    //    if (PlayerPrefs.HasKey("SavedHighScore"))
    //    {

    //        if (score > PlayerPrefs.GetInt("SavedHighScore"))
    //        {
    //            PlayerPrefs.SetInt("SavedHighScore", score);
    //        }
    //    }
    //    else
    //    {
    //        PlayerPrefs.SetInt("SavedHighScore", score);
    //    }
    //    finalScoreText.text = score.ToString();
    //    highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    //}
    //public void StopSpawning()
    //{
    //    CancelInvoke();
    //}
    // public static Score instance;

    // public TextMeshProUGUI scoreText;
    // public TextMeshProUGUI highScoreText;

    // int score = 0;
    // int highScore = 0;

    // private void Awake()
    // {
    //     instance = this;
    // }
    // private void Start()
    // {
    //     highScore = PlayerPrefs.GetInt("highscore", 0);
    //     scoreText.text = "SCORE: " + score.ToString();
    //     highScoreText.text = "HIGHSCORE: " + highScore.ToString();
    // }
    //public void AddPoint()
    // {
    //     score += 10;
    //     scoreText.text = "SCORE: " + score.ToString();
    //     if (highScore <score)
    //         PlayerPrefs.SetInt("highscore", score);
    // }
}
