﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
public class GetMoney : MonoBehaviour
{
    private RewardedAd rewardAd;
    // Start is called before the first frame update
    public void Awake()
    {

        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif
        this.rewardAd = new RewardedAd(adUnitId);
        this.rewardAd.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewardAd.OnAdClosed += HandleRewardedAdClosed;
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardAd.LoadAd(request);
    }

    public void HandleUserEarnedReward(object sender, EventArgs args)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + PlayerPrefs.GetInt("Money"));
    }
    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        this.CreateAndLoadRewardedAd();
    }

    public void CreateAndLoadRewardedAd()
    {
        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif
        this.rewardAd = new RewardedAd(adUnitId);
        this.rewardAd.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewardAd.OnAdClosed += HandleRewardedAdClosed;
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardAd.LoadAd(request);
    }
    // Update is called once per frame


    void OnMouseDown()
    {
        
         this.rewardAd.Show();
        
    }

}
