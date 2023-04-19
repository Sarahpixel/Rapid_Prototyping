using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }
    public void LoadGame()
    {
        
        Time.timeScale = 1.5f;
        SceneManager.LoadScene("CatchGame");
    }
    public void QuitGame()
    {
        Debug.Log("Quiting Game.....");
        Application.Quit();
    }
}
