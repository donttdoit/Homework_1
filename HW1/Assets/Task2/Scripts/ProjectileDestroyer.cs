using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Projectile projectile))
        {
            Destroy(projectile.gameObject);
        }
    }
}
