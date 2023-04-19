using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : GameBehaviour
{
    public int score;
    public int highScore;
    public string playTime;
    GameDataManager _Data;

    // Start is called before the first frame update
    void Start()
    {
        _Data =  GameDataManager.INSTANCE;
        score = 0; /*GameDataManager.INSTANCE.GetScore();*/
        highScore = GameDataManager.INSTANCE.GetHighestScore();
        playTime = GameDataManager.INSTANCE.GetTimeFormatted();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Save();
        }
    }
    void Save()
    {
        _Data.SetScore(score);
        _Data.SetTimePlayed();
        _Data.SaveData();

    }
}
