using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject gomenu;
    public GameObject restartb;
    public GameObject resumeb;
    public GameObject quitb;
    public GameObject pause;


    public void GameOver()
    {
        //pause.SetActive(false);
        gomenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Pause()
    {
        pause.SetActive(false);
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        menu.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1;
        print("went to start menu");
    }
}
