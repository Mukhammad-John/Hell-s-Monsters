using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRedGem : MonoBehaviour
{
    private Animator myAnimator;
    public Animator countCoin;
    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
        countCoin = GameObject.Find("CountCoin").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("GemNothing"))
        {
            countCoin.SetTrigger("count");
            GiveDamage.CoinCount += PlayerPrefs.GetInt("Luck") + 5;
            Level.LevelCoin += PlayerPrefs.GetInt("Luck") + 5;
            Destroy(gameObject);
        }
    }
}
