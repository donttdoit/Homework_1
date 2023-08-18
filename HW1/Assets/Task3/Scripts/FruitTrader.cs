using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTrader : Trader
{
    protected override void Trade()
    {
        Debug.Log("Я продаю фрукты");
    }
}
