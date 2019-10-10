using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float magnitud = 90;
    [SerializeField] GameObject fire;
    [SerializeField] GameObject pivote;
    [SerializeField] AudioClip firing;

    AudioSource maudio;
    // Start is called before the first frame update
    void Start()
    {
        maudio = GetComponent<AudioSource>();
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

        if (Input.GetButtonDown("Fire3"))
        {
            GameObject clon = Instantiate(fire, pivote.transform.position, Quaternion.identity);
            Rigidbody cuerpoClon = clon.GetComponent<Rigidbody>();
            clon.transform.eulerAngles = transform.eulerAngles;

            cuerpoClon.AddForce(transform.forward * 1200);
            maudio.Play();

        }


    }
}
