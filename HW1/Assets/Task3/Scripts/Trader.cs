using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _requiredReputationForTrade;

    public int RequiredReputationForTrade => _requiredReputationForTrade;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            if (player.Reputation < _requiredReputationForTrade)
            {
                Debug.Log("У Вас недостаточно репутации для торговли");
                return;
            }
            Trade();
        }
    }

    abstract protected void Trade();
}
