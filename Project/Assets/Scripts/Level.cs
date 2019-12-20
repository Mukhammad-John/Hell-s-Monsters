using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using UnityEngine.Networking;

using System.IO;
using System;

[Serializable]
public class Level : MonoBehaviour
{

    private TextMesh LevelText;

    [SerializeField]
    private TextMesh ReceivedCoins;
    [SerializeField]
    private TextMesh YourTime;
    [SerializeField]
    private TextMesh YourBestTime;
    public static int LevelCoin = 0;
    public static float LevelTime = 0;
    public static bool GameOn = true;
    [SerializeField]
    private GameObject enemy;
    public static int LevelCount = 1;
    private float yourBestTime;

    public GameObject GiveDamage;
    void Awake()
    {
        GiveDamage.GetComponent<GiveDamage>().enabled = true;
        GameOn = true;
        yourBestTime = PlayerPrefs.GetFloat("BestTime");
        Instantiate(enemy, new Vector2(-3.289465f, 2.67f), Quaternion.identity);
    }
    void Update()
    {
        GiveDamage.GetComponent<GiveDamage>().enabled = true;

        if (LevelCount == 11 && (LevelTime <= PlayerPrefs.GetFloat("BestTime")))
        {
            PlayerPrefs.SetFloat("BestTime", LevelTime);
        }
        LevelText = GameObject.Find("LvlText").GetComponent<TextMesh>();
        LevelText.text = LevelCount.ToString();
        ReceivedCoins.text = LevelCoin.ToString();
        YourTime.text = LevelTime.ToString();
        YourBestTime.text = PlayerPrefs.GetFloat("BestTime").ToString();
    }




}

