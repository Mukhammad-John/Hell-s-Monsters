using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopButtons : MonoBehaviour
{

    public void AddDamage()
    {
        if (PlayerPrefs.GetInt("Coins") >= PlayerPrefs.GetInt("Damage") * 100)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (PlayerPrefs.GetInt("Damage")) * 100);
            PlayerPrefs.SetInt("Damage", PlayerPrefs.GetInt("Damage") + 1);
        }
    }

    public void AddLuck()
    {
        if (PlayerPrefs.GetInt("Coins") >= PlayerPrefs.GetInt("Luck") * 100)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (PlayerPrefs.GetInt("Luck")) * 100);
            PlayerPrefs.SetInt("Luck", PlayerPrefs.GetInt("Luck") + 1);
        }
    }

    public void AddCoiner()
    {
        if (PlayerPrefs.GetInt("Coins") >= PlayerPrefs.GetInt("Coiner") * 100)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (PlayerPrefs.GetInt("Coiner")) * 100);
            PlayerPrefs.SetInt("Coiner", PlayerPrefs.GetInt("Coiner") + 1);
        }
    }
    public void Back()
    {
        SceneManager.LoadScene("Game");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
