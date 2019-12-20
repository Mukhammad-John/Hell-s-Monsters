using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{
    private TextMesh damageCost;
    private TextMesh luckCost;
    private TextMesh coinerCost;
    private TextMesh damageNumber;
    private TextMesh luckNumber;
    private TextMesh coinerNumber;
    private TextMesh moneyNumber;
    private TextMesh coins;
    public GameObject Back;
    void Start()
    {
        if (GiveDamage.time < 60)
        {
            Back.SetActive(true);
        }
        else
        {
            Back.SetActive(false);
        }
        damageCost = GameObject.Find("damageCost").GetComponent<TextMesh>();
        luckCost = GameObject.Find("luckCost").GetComponent<TextMesh>();
        coinerCost = GameObject.Find("coinerCost").GetComponent<TextMesh>();
        damageNumber = GameObject.Find("damageNumber").GetComponent<TextMesh>();
        luckNumber = GameObject.Find("luckNumber").GetComponent<TextMesh>();
        coinerNumber = GameObject.Find("coinerNumber").GetComponent<TextMesh>();
        moneyNumber = GameObject.Find("moneyNumber").GetComponent<TextMesh>();
        coins = GameObject.Find("coins").GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {
        damageCost.text = (PlayerPrefs.GetInt("Damage") * 100).ToString();
        luckCost.text = (PlayerPrefs.GetInt("Luck") * 100).ToString();
        coinerCost.text = (PlayerPrefs.GetInt("Coiner") * 100).ToString();
        damageNumber.text = "x " + PlayerPrefs.GetInt("Damage").ToString();
        luckNumber.text = "x " + PlayerPrefs.GetInt("Luck").ToString();
        coinerNumber.text = "x " + PlayerPrefs.GetInt("Coiner").ToString();
        moneyNumber.text = "x " + PlayerPrefs.GetInt("Money").ToString();
        coins.text = PlayerPrefs.GetInt("Coins").ToString();

    }
}
