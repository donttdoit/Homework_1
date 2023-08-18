using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShootInfinityAmmoGun : IGun
{

    public void Shoot()
    {
        Debug.Log("Огонь! У вас бесконечные патроны");
    }
}
