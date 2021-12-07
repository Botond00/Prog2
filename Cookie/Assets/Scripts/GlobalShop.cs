using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour {
    
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 10;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int shopPerSec;


    void Update() {
        currentCash = GlobalCash.CashCount;
        shopStats.GetComponent<Text>().text = "Shops: " + numberOfShops + " @ " + shopPerSec + " Per Second";
        realText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        if (currentCash >= shopValue)
        {
            realButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            realButton.GetComponent<Button>().interactable = false;
        }
    }
}
