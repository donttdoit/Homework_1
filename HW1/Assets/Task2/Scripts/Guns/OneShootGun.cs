using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShootGun: IGun
{
    private readonly int COUNT_AMMO_IN_CLIP;
    private int _currentCountAmmoInClip;
    private int _countOfAmmo;
    
    public OneShootGun(int ammoInClip, int CountOfAmmo)
    {
        COUNT_AMMO_IN_CLIP = _currentCountAmmoInClip = ammoInClip;
        _countOfAmmo = CountOfAmmo;
    }

    public void Shoot()
    {
        if (_currentCountAmmoInClip <= 0 && _countOfAmmo <= 0)
        {
            Debug.Log("Кончились патроны");
            return;
        }
        if (_currentCountAmmoInClip <= 0)
        {
            ((IGun)this).Reload(ref _currentCountAmmoInClip, ref _countOfAmmo, COUNT_AMMO_IN_CLIP);
        }
        _currentCountAmmoInClip--;
        Debug.Log($"Огонь! Патроны: {_currentCountAmmoInClip}/{_countOfAmmo}");
    }

}
