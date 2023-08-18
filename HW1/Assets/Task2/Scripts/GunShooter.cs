using UnityEngine;

public class GunShooter : MonoBehaviour
{
    [SerializeField] private GunData _gunData;
    private IGun _gun;
    private void Awake()
    {
        _gun = new OneShootGun(5, 10);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _gun.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Вы взяли обычное оружие");
            _gun = new OneShootGun(5, 10);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Вы взяли оружие с бесконечными патронами");
            _gun = new OneShootInfinityAmmoGun();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Вы взяли оружие с тремя патронами на выстрел");
            _gun = new ThreeShooterGun(6, 9);
        }
    }
}
