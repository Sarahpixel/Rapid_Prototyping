using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void LoadTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TreeTitle");
    }
    public void Restart()
    {
        Time.timeScale = 2f;
        SceneManager.LoadScene("CatchGame");
    }
    public void QuitGame()
    {
        Debug.Log("Quiting Game.....");
        Application.Quit();
    }
}
