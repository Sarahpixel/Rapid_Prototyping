using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaving : GameBehaviour
{
    int score = 0;
    int highScore = 0;

    void Start()
    {
        print("Score" + score);
        highScore = PlayerPrefs.GetInt("HighScore");
        print("HighScore" + highScore);


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            print("Score: " + score);
        }
           

        if (Input.GetKeyDown(KeyCode.G))
            GameOver();

        if (Input.GetKeyDown(KeyCode.P))
            PlayerPrefs.DeleteKey("HighScore");
    }
    void GameOver()
    {
        print("Game Over");
        if(score > highScore)
        {
            highScore = score;
            print("New High Score! " + highScore);
            PlayerPrefs.SetInt("HighScore", score);
        }
        
    }
}
