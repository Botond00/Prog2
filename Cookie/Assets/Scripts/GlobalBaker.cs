using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour {
    
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 10;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;


    void Update() {
        
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberOfBakers + " @ " + bakePerSec + " Per Second";
        realText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        
        if (currentCash >= bakerValue)
        {
            realButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            realButton.GetComponent<Button>().interactable = false;
        }

    }
}
