using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class GameButtons : MonoBehaviour
{




    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject pauseButton;
    [SerializeField]
    private GameObject pauseButtons;



    public void PauseGame()
    {


        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        pauseButtons.SetActive(true);
        pauseButton.SetActive(false);

    }



    public void RestartGame()
    {
        GiveDamage.time = 60;
        Level.LevelCoin = 0;
        Level.LevelCount = 1;
        Level.LevelTime = 0;
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

    public void ContinueGame()
    {


        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        pauseButtons.SetActive(false);
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
