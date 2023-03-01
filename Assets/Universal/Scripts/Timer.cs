using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TimerDirection { CountUp, CountDown }
public class Timer : GameBehaviour<Timer>
{
  
    public TimerDirection timerDirection;
    public float startTime = 0;
    float currentTime;
    bool isTiming =false;
    float timeLimit = 0;
    bool hasTimeLimit = false;
  
    void Update()
    {
        if(!isTiming)
            return;
        //if the timer direction == TimerDirectio.CountUp, increment the current time, else decrement the current time
        currentTime = timerDirection == TimerDirection.CountUp ? currentTime += Time.deltaTime : currentTime += Time.deltaTime;
        

    }
    /// <summary>
    /// changes the direction of the time
    /// </summary>
    /// <param name="_direction">the Direction to change to</param>
    public void ChangeTimerDirection(TimerDirection _direction)
    {
        timerDirection = _direction;
    }
    /// <summary>
    /// Starts the timer
    /// </summary>
    /// <param name="_startTime">start of the timer, Defaults to 0</param>
    public void StartTimer(float _startTime = 0, TimerDirection _direction = TimerDirection.CountUp)
    {
        timerDirection = _direction;
        startTime = _startTime;
        isTiming = true;
    }
    /// <summary>
    /// starts a timer is an overload function
    /// </summary>
    /// <param name="_startTime">starts the time</param>
    /// <param name="_timeLimit">what's the time limit</param>
    /// <param name="_hasTimeLimit">uses the time limit</param>
    public void StartTimer(float _startTime = 0, float _timeLimit = 0, bool _hasTimeLimit = true, TimerDirection _direction = TimerDirection.CountUp)
    {
        timerDirection = _direction;
        hasTimeLimit = _hasTimeLimit;
        timeLimit = _timeLimit;
        startTime = _startTime;
        isTiming = true;

    }
    // Resume the timer
    public void ResumeTimer()
    {
        isTiming = true;
    }
    public void PauseTimer()
    {
        isTiming = false;
    }
    /// <summary>
    /// Increment out timer
    /// </summary>
    /// <param name="_increment">The amount to increment our timer</param>
    public void IncrementTimer(float _increment)
    {
        currentTime += _increment;
    }
    /// <summary>
    /// Decrement out timer
    /// </summary>
    /// <param name="_decrement">The amount to decrement our timer</param>
    public void DecrementTimer(float _decrement)
    {
        currentTime -= _decrement;
    }
    public bool TimeExpired()
    {
        if(!hasTimeLimit)
            return false;

        return timerDirection == TimerDirection.CountUp ? currentTime > timeLimit : currentTime < timeLimit;
    }
    /// <summary>
    /// Checks to see if we're timing 
    /// </summary>
    /// <returns> Returns isTiming</returns>
    public bool IsTiming()
    {
        return isTiming;
    }
    /// <summary>
    /// gets the current time
    /// </summary>
    /// <returns> returns the current time</returns>
    public float Gettime()
    {
        return currentTime;
    }
    public void StopTimer()
    {
        isTiming = false;
    }
}
