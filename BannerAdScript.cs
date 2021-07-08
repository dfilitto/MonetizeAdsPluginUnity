using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAdScript : MonoBehaviour
{
	//código do jogo no Android ou IOS
    string gameId = "4110283";
	//código da propaganda
    string myPlacementId = "BannerADS";
	//se a propaganda esta em teste ou não
    bool testMode = false;

    void Start()
    {
		//Inicia a propaganda
        Advertisement.Initialize(gameId, testMode);
        //definir local do banner TOP_LEFT, TOP_CENTER, TOP_RIGHT, BOTTOM_LEFT, BOTTOM_CENTER, BOTTOM_RIGHT, CENTER
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        StartCoroutine(ShowBannerWhenInitialized());
    }

    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(myPlacementId);
    }
}
