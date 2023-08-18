using UnityEngine;

public class ThreeShooterGun : IGun
{
    private readonly int COUNT_AMMO_IN_CLIP;
    private int _currentCountAmmoInClip;
    private int _countOfAmmo;

    public ThreeShooterGun(int ammoInClip, int CountOfAmmo)
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
        _currentCountAmmoInClip -= 3;
        Debug.Log($"Огонь! Патроны: {_currentCountAmmoInClip}/{_countOfAmmo}");
    }
}
