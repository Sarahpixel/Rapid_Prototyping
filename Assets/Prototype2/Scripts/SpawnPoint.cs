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
    //public GameObject sphere;
    //public GameObject fire;
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public GameObject[] spawnPoint;
    public int spawnCount;
    private int randomSpawnPoint;
    [SerializeField] TextMeshProUGUI highscoreText;

    public TextMeshProUGUI scoreText;

    public Player player;

    public void Start()
    {
        //UpdateHighScore();
        //sets the _timer to timer
        _timer = timer;
    }
    void CheckHighScore()
    {
        if (player.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", player.score);

            UpdateHighScoreText();
        }
    }
    void UpdateHighScoreText()
    {
        highscoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }

    public void Update()
    {
        //highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
        if (timer > 0)
            timer -= 1 * Time.deltaTime;

        if (timer <= 0)
            Spawn();

        if (player.score < 0)
        {
            player.score = 0;
        }
        scoreText.text = ("SCORE: ") + player.score.ToString();


    }
    public void Spawn()
    {
        if(timer <=0)
        {
            if(enemiesToSpawn.Count > 0)
            {
                randomSpawnPoint = Random.Range(0, spawnCount);
                Instantiate(enemiesToSpawn[0], spawnPoint[randomSpawnPoint].transform.position, Quaternion.identity);
                timer = _timer;
            }
        }
        
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
