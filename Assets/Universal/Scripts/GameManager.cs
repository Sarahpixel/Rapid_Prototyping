using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GameBehaviour<GameManager>
{
    //private bool wonGame = false;
    //public TMP_Text WinText;
    //public GameObject winPanel;

    public GameObject WinPannel;

    public void CompleteGame()
    {
        Cursor.lockState = CursorLockMode.None;
        WinPannel.SetActive(true);
    }
    public void LoadTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
    //void Start()
    //{

    //    _TIMER.StartTimer(0,TimerDirection.CountUp);
    //}
    //void FixedUpdate()
    //{
    //    //if we have won the game, return the function
    //    if (wonGame == true)
    //        return;


    //}
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.C))
    //        _TIMER.ChangeTimerDirection(TimerDirection.CountUp);
    //    if (Input.GetKeyDown(KeyCode.U))
    //        _TIMER.ChangeTimerDirection(TimerDirection.CountDown);

    //    if (Input.GetKeyDown(KeyCode.P))
    //    {
    //        if (_TIMER.IsTiming())
    //            _TIMER.PauseTimer();
    //        else
    //            _TIMER.ResumeTimer();
    //    }


    //    if (_TIMER.TimeExpired())
    //        Debug.Log("Timer Expired");
    //}
}
