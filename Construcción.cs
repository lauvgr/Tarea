using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construcción : MonoBehaviour
{
    
    [SerializeField] float salud = 100;
    [SerializeField] MotorLau tanque;

    public void Damage()
    {
        salud -= tanque.damage / 2;
    }
}
