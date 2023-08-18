using System.Collections.Generic;
using UnityEngine;

public class SphereStats : MonoBehaviour
{
    [SerializeField] private List<Sphere> _spheres;
    public List<Sphere> Spheres => _spheres;

    private void Awake()
    {
        foreach (Sphere sphere in _spheres)
        {
            sphere.SphereClicked += RemoveSphereFromList;
        }
    }

    private void OnDestroy()
    {
        foreach (Sphere sphere in _spheres)
        {
            sphere.SphereClicked -= RemoveSphereFromList;
        }
    }


    public int GetCountOfSpheres() => _spheres.Count;

    private void RemoveSphereFromList(Sphere sphere) 
    { 
        _spheres.Remove(sphere);
    }
}
