using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startmenu : MonoBehaviour
{
    public int lives = 5;
    public int coins = 0;
    public void loadlevel()
    {
      Time.timeScale = 1;
      SceneManager.LoadScene("SampleScene");
      PlayerPrefs.SetInt("lives", lives);
      PlayerPrefs.SetInt("coins", coins);
    }

    public void quitgame()
    {
        Application.Quit();
    }

    public void settings()
    {

    }

    public void Reset()
    {
        PlayerPrefs.SetInt("lives", lives);
        PlayerPrefs.SetInt("coins", coins);
    }
}
