using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    
    public static bool SellingCookie = false;
    public static int CashIncrease = 1;
    public static int InternalIncrease;

    void Update() {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie()); 
        }
    }

    public static IEnumerator SellTheCookie ()
    {
        if (GlobalCookies.CookieCount <= InternalIncrease - 1)
        {
            GlobalCash.CashCount += GlobalCookies.CookieCount;
            GlobalCookies.CookieCount -= GlobalCookies.CookieCount;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalCookies.CookieCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
    }
}
