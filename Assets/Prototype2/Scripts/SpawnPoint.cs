using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnPoint : MonoBehaviour
{
    //Game variables
    public float timer;
    public float _timer; //default timer that will be set constantly to what our timer is at start
    public GameObject sphere;
    public GameObject[] spawnPoint;
    public int spawnCount;
    private int randomSpawnPoint;

    public TextMeshProUGUI scoreText;

    public Player player_Script;

    public void Start()
    {
        //UpdateHighScore();
        //sets the _timer to timer
        _timer = timer;
    }

    public void Update()
    {
        //highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
        if (timer > 0)
            timer -= 1 * Time.deltaTime;

        if (timer <= 0)
            Spawn();

        if (player_Script.score < 0)
        {
            player_Script.score = 0;
        }
        scoreText.text = ("SCORE: ") + player_Script.score.ToString();


    }
    public void Spawn()
    {
        randomSpawnPoint = Random.Range(0, spawnCount);
        Instantiate(sphere.transform, spawnPoint[randomSpawnPoint].transform.position, Quaternion.identity);
        timer = _timer;
        //for(int i = 0; i < spawnCount; i++) //for loop

    }
    //void HighScore()
    //{
    //    if (player_Script.score > PlayerPrefs.GetInt("HighScore", 0))
    //    {
    //        PlayerPrefs.SetInt("HighCore", player_Script.score);
    //    }
    //}
   
}
