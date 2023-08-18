using UnityEngine;

public interface IGun
{
    public void Shoot();
    public void Reload(ref int currentCountAmmoInClip, ref int countOfAmmo, int countOfAmmoInClip)
    {
        if (countOfAmmo < countOfAmmoInClip)
        {
            currentCountAmmoInClip = countOfAmmo;
            countOfAmmo = 0;
        }
        else
        {
            currentCountAmmoInClip = countOfAmmoInClip;
        }
        
        if (countOfAmmo > 0)
            countOfAmmo -= countOfAmmoInClip;
        Debug.Log($"ѕерезар¤жаюсь! ѕатроны: {currentCountAmmoInClip}/{countOfAmmo}");
    }
}
