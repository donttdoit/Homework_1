using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _reputation;

    public int Reputation => _reputation;
}
