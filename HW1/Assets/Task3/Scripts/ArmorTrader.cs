using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorTrader : Trader
{
    protected override void Trade()
    {
        Debug.Log("Я продаю броню");
    }
}
