using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 35f;
    public TextMeshProUGUI timerText;
    public GameObject inGamePanel;
    public GameObject pausePanel;

    public GameObject gameOverPanel;

    
    
    void Start()
    {
        gameOverPanel.SetActive(false);
        currentTime = startingTime;
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;

        }
        if(currentTime==0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            pausePanel.SetActive(false);
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            inGamePanel.SetActive(false);
            ////call the update high score
            //spawnPoint.UpdateHighScore();
        }
        if (currentTime <5.5f)
        {
            timerText.color = Color.red;
        }
        if (currentTime >= 5.5f)
        {
            timerText.color = Color.black;
        }
        //else if(currentTime <= 0 && startingTime <= 0)
        //{
        //    Debug.Log("GameOver..");
        //}


            //if(startingTime <=0)
            //{
            //   
            //}


    }

  
    
}
