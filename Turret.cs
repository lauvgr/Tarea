﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    [SerializeField] float magnitud = 90;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirAng = new Vector3(0, 1, 0) * Input.GetAxis("Fire1");
        Vector3 velAng = magnitud * (dirAng);
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        Vector3 dirAng2 = new Vector3(0, -1, 0) * Input.GetAxis("Fire2");
        Vector3 velAng2 = magnitud * (dirAng2);
        Vector3 distAng2 = velAng2 * Time.deltaTime;
        transform.eulerAngles += distAng2;
    }
}