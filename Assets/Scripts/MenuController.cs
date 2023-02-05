using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void DestroyCash()
    {
        PlayerPrefs.DeleteAll();
    }
}
