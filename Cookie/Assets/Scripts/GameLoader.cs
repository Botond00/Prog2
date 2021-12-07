using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {
    
    public GameObject AutoCookie;
    public GameObject AutoSell;
   
    public int savedCookies;
    public int savedCash;

    public int savedBakers;
    public int savedShops;

    public int savedBPs;
    public int savedSPs;

    public int savedBValue;
    public int savedSValue;
    public int savedValue;

    void Start() {
        if (MainMenuOptions.isLoading == true && PlayerPrefs.GetInt("SaveValue") > 10)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = savedCookies;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;

            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.numberOfBakers = savedBakers;
            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;
            
            savedBPs = PlayerPrefs.GetInt("SavedBPs");
            GlobalBaker.bakePerSec = savedBPs;
            savedSPs = PlayerPrefs.GetInt("SavedSPs");
            GlobalShop.shopPerSec = savedSPs;
            
            savedBValue = PlayerPrefs.GetInt("SaveBValue");
            GlobalBaker.bakerValue = savedBValue;
            savedSValue = PlayerPrefs.GetInt("SaveSValue");
            GlobalShop.shopValue = savedSValue;
            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
            AutoCookie.SetActive(true);
            AutoSell.SetActive(true);
        }
        
    }


}
