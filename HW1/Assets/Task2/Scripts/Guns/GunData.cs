using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GunData
{
    private int _countOfAmmo;
    private int _countAmmoInClip;
    private int _shotsInOneFire;

    public int CountOfAmmo { get => _countOfAmmo; set => _countOfAmmo = value; }
    public int CountAmmoInClip { get => _countAmmoInClip; set => _countAmmoInClip = value; }
    public int ShotsInOneFire { get => _shotsInOneFire; set => _shotsInOneFire = value; }

    public GunData(int countOfAmmo, int countAmoInClip, int shotsInOneFire)
    {
        _countOfAmmo = countOfAmmo;
        _countAmmoInClip = countAmoInClip;
        _shotsInOneFire = shotsInOneFire;
    }

}

