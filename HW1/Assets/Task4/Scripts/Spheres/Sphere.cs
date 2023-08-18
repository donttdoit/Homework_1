using System;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public event Action<Sphere> SphereClicked;

    void OnMouseDown()
    {
        SphereClicked?.Invoke(this);
        Destroy(gameObject);
    }

}
