using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;


public class GiveDamage : MonoBehaviour
{
    [SerializeField]
    private TextMesh GameCounnt;
    [SerializeField]
    private TextMesh Timer;
    [SerializeField]
    private GameObject pause;
    [SerializeField]
    private GameObject Coin;
    [SerializeField]
    private GameObject WinWindow;
    [SerializeField]
    private GameObject LoseWindow;
    [SerializeField]
    private GameObject LoseButtons;
    [SerializeField]
    private GameObject WinButtons;
    
    public static float time;
    public static int CoinCount;

    private int saveGems = 0;
    public static float DamageOnLevels;
    private string count;

    public static bool CanSpawn = true;
    private void Awake()
    {
        WinWindow.SetActive(false);
        WinButtons.SetActive(false);
        LoseButtons.SetActive(false);
        LoseWindow.SetActive(false);
    }
    private void Start()
    {
        Timer.text = Mathf.RoundToInt(time).ToString();

        GameCounnt.text = CoinCount.ToString();
        DamageOnLevels = (3f / (((float)Level.LevelCount + 9) / (float)PlayerPrefs.GetInt("Damage")));
        //gameCount = saveGems;
        CoinCount = PlayerPrefs.GetInt("Coins");
    }
    void OnMouseDown()
    {

        if (Enemy.life > 0 && Enemy.CanDamage && Level.GameOn)
        {

            Enemy.MyAnimator.Play("AttackedAnimation");
            Enemy.life -= PlayerPrefs.GetInt("Damage");
            HealthBar.HealthLong -= 0.3f;

            if (HealthBar.bar.localScale.x > 0)
            {
                HealthBar.bar.localScale -= new Vector3(DamageOnLevels, 0, 0);
            }



        }
        if (Enemy.life >= 1 && Level.GameOn && CanSpawn)
        {
            Instantiate(Coin, new Vector2(0, 0), Quaternion.identity);
        }

    }
    private void Update()
    {
        PlayerPrefs.SetInt("Coins", CoinCount);
        if (Level.LevelCount == 11)
        {
            Level.GameOn = false;
            WinWindow.SetActive(true);
            WinButtons.SetActive(true);
            pause.SetActive(false);
        }
        if (HealthBar.bar.localScale.x <= 0)
        {
            HealthBar.bar.localScale = new Vector3(0, 0, 0);
        }
        if (Level.GameOn)
        {
            time -= Time.deltaTime;
        }


        Timer.text = Mathf.RoundToInt(time).ToString();
        if (Level.GameOn)
        {
            Level.LevelTime = 60f - Mathf.Round(time * 10f) / 10f;
        }
        if (CoinCount / 1000 >= 1)
        {
            if (CoinCount % 1000 > 100)
            {
                count = (CoinCount / 1000).ToString() + "." + (CoinCount % 1000 / 100) + "k";
            }
            else
            {
                count = (CoinCount / 1000).ToString() + "k";
            }

        }
        else
        {
            count = CoinCount.ToString();
        }
        GameCounnt.text = count;
        if ((((float)Level.LevelCount + 9) / (float)PlayerPrefs.GetInt("Damage")) >= 1)
        {
            DamageOnLevels = (3f / (((float)Level.LevelCount + 9) / (float)PlayerPrefs.GetInt("Damage")));
        }
        else
        {
            DamageOnLevels = 3;
        }

        if (time <= 0)
        {
            Level.GameOn = false;

        }
        else if (Level.LevelCount != 11)
        {
            pause.SetActive(true);
            Level.GameOn = true;
        }

        if (CoinCount < 1000)
        {

            PlayerPrefs.SetInt("Money", 100);
        }
        else
        {
            PlayerPrefs.SetInt("Money", CoinCount / 10);
        }
        if (time < 0)
        {
            time = 0;

        }
        if (time <= 0)
        {
            pause.SetActive(false);
            LoseWindow.SetActive(true);
            LoseButtons.SetActive(true);
        }
        else
        {
            LoseWindow.SetActive(false);
            LoseButtons.SetActive(false);
        }

    }


}
