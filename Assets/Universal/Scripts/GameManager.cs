using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GameBehaviour<GameManager>
{
    
    void Start()
    {
        _TIMER.StartTimer(0,TimerDirection.CountUp);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            _TIMER.ChangeTimerDirection(TimerDirection.CountUp);
        if (Input.GetKeyDown(KeyCode.U))
            _TIMER.ChangeTimerDirection(TimerDirection.CountDown);

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (_TIMER.IsTiming())
                _TIMER.PauseTimer();
            else
                _TIMER.ResumeTimer();
        }


        if (_TIMER.TimeExpired())
            Debug.Log("Timer Expired");
    }
}
