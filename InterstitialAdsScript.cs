using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAdsScript
{

    public string GameId { get; set; }
    public string MyPlacementId { get; set; }
    public bool TestMode { get; set; }

    //construtor com parâmetros já definidos
    //public InterstitialAdsScript()
    //{
    //    //O ideal é não deixar pré definido esses valores
    //    //o ideal é utilizar o outro construtor
    //    this.GameId = "4110283";
    //    this.MyPlacementId = "VideoADS";
    //    this.TestMode = true;
    //    Advertisement.Initialize(GameId, TestMode);
    //}

    public InterstitialAdsScript(string gameId, string myPlacementId, bool testMode)
    {
        
        this.GameId = gameId;
        this.MyPlacementId = myPlacementId;
        this.TestMode = testMode;
        Advertisement.Initialize(GameId, TestMode);
    }
    public void ShowInterstitialAd()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady())
        {
            Advertisement.Show(MyPlacementId);
        }
        else
        {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
    }
}
