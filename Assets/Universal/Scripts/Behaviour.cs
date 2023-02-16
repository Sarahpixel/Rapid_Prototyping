using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace BV
{
    public class Behaviour : MonoBehaviour
    {

        /// <summary>
        /// GETS A RANDOM SET OF COLORS
        /// </summary>
        /// <returns></returns>
        public Color GetRandomColor()
        {
            return new Color(UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f));
        }

        /// <summary>
        /// scales the game object to zero
        /// </summary>
        /// <param name="_go"> the game object we want to scale</param>
        public void ScaleToZero(GameObject _go)
        {
            _go.transform.localScale = Vector3.zero;
        }


        #region Coroutine Helpers
        /// <summary>
        /// Executes the Action block as a Coroutine on the next frame.
        /// </summary>
        /// <param name="func">The Action block</param>
        protected void ExecuteNextFrame(Action func)
        {
            StartCoroutine(ExecuteAfterFramesCoroutine(1, func));
        }
        /// <summary>
        /// Executes the Action block as a Coroutine after X frames.
        /// </summary>
        /// <param name="func">The Action block</param>
        protected void ExecuteAfterFrames(int frames, Action func)
        {
            StartCoroutine(ExecuteAfterFramesCoroutine(frames, func));
        }
        private IEnumerator ExecuteAfterFramesCoroutine(int frames, Action func)
        {
            for (int f = 0; f < frames; f++)
                yield return new WaitForEndOfFrame();
            func();
        }
        /// <summary>
        /// Executes the Action block as a Coroutine after X seconds
        /// </summary>
        /// <param name="seconds">Seconds.</param>
        protected void ExecuteAfterSeconds(float seconds, Action func)
        {
            if (seconds <= 0f)
                func();
            else
                StartCoroutine(ExecuteAfterSecondsCoroutine(seconds, func));
        }
        private IEnumerator ExecuteAfterSecondsCoroutine(float seconds, Action func)
        {
            yield return new WaitForSeconds(seconds);
            func();
        }
        /// <summary>
        /// Executes the Action block as a Coroutine whern a condition is met
        /// </summary>
        /// <param name="condition">The Condition block</param>
        /// <param name="func">The Action block</param>
        protected void ExecuteWhenTrue(Func<bool> condition, Action func)
        {
            StartCoroutine(ExecuteWhenTrueCoroutine(condition, func));
        }
        private IEnumerator ExecuteWhenTrueCoroutine(Func<bool> condition, Action func)
        {
            while (condition() == false)
                yield return new WaitForEndOfFrame();
            func();
        }
    
    
  
  
        #endregion
    }

}