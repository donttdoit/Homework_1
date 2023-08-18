using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotTrader : Trader
{
    protected override void Trade()
    {
        Debug.Log("Я не торгую");
    }
}
