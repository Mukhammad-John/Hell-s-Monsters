using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class MenuButtons : MonoBehaviour
{

    public void StartGameFunction()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void ShopLoad()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Shop");
    }



    public void ChampionsLoad()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Champions");

    }
    public void Exit()
    {
        Application.Quit();
    }





}
