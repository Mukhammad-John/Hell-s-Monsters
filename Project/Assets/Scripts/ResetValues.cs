using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValues : MonoBehaviour
{

    void Awake()
    {
        if (PlayerPrefs.GetInt("Damage") == 0)
        {
            PlayerPrefs.SetInt("Damage", 1);
        }
        if (PlayerPrefs.GetFloat("BestTime") == 0)
        {
            PlayerPrefs.SetFloat("BestTime", 100);
        }
        if (PlayerPrefs.GetInt("Luck") == 0)
        {
            PlayerPrefs.SetInt("Luck", 1);
        }
        if (PlayerPrefs.GetInt("Coiner") == 0)
        {
            PlayerPrefs.SetInt("Coiner", 1);
        }

        if (PlayerPrefs.GetInt("Money") == 0)
        {
            PlayerPrefs.SetInt("Money", 100);
        }
        GiveDamage.time = 60;
        Level.LevelCoin = 0;
        Level.LevelCount = 1;
        Level.LevelTime = 0;
    }


}
