using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Animator myAnimator;
    private Animator countCoin;

    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
        countCoin = GameObject.Find("CountCoin").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("CoinIdle"))
        {
            countCoin.SetTrigger("count");
            GiveDamage.CoinCount += PlayerPrefs.GetInt("Luck");
            Level.LevelCoin += PlayerPrefs.GetInt("Luck");
            Destroy(gameObject);
        }
    }
}
