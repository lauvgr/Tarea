using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    // Start is called before the first frame update
    float magnitud = 8;
    float magnitud2 = 60;
    AudioSource maudio;
    Rigidbody tanque;
    void Start()
    {
        maudio = GetComponent<AudioSource>();
        tanque = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        maudio.mute = true;
        Vector3 dir = transform.forward * Input.GetAxis("Vertical");
        Vector3 vel = magnitud * dir;
        Vector3 dist = vel * Time.deltaTime;
        transform.position += dist;


        Vector3 dirAng = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magnitud2 * dirAng;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        if (dir.z > 0 || dir.z < 0 || dirAng.y < 0 || dirAng.y > 0)
        {
            maudio.mute = false;
        }



        //dash

        float magnitud3 = 400;
        float sentido = 1;
        Vector3 dir2 = transform.forward;
        Vector3 fuerza = magnitud3 * dir2 * sentido;
        float magnitud4 = 200;
        float sentido2 = 1;
        Vector3 dir3 = new Vector3(0, 1, 0);
        Vector3 fuerza2 = magnitud4 * dir3 * sentido2;

        if (Input.GetButtonDown("Jump"))
        {
            tanque.AddForce(fuerza);
            tanque.AddForce(fuerza2);
        }
    }
}