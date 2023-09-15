using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : IDisposable
{
    private IWinCondition _winCondition;
    private SpheresList _spheresList;

    public Level(IWinCondition winCondition, SpheresList spheresList)
    {
        _winCondition = winCondition;
        _spheresList = spheresList;
        _spheresList.SphereDestroyed += CheckWin;
    }

    public void Dispose()
    {
        _spheresList.SphereDestroyed -= CheckWin;
    }

    public void SetConditionToWin(IWinCondition winCondition) => _winCondition = winCondition;

    private void CheckWin()
    {
        if (_winCondition.CheckWinResult())
        {
            Debug.Log("Победа");
        }
    }

    
}
