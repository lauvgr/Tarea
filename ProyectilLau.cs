using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilLau : MonoBehaviour
{
    float t = 0;
    [SerializeField] float duracion = 5f;
    [SerializeField] float fuerza = 1200;

    Rigidbody rb;

    MotorLau motor;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       motor = GetComponent<MotorLau>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= duracion)
        {
            Destroy(gameObject);
        }
        

        
    }
    public void Disparar()
    {
        rb.AddForce(transform.forward * fuerza);
    }
    void OnCollisionEnter(Collision tanque)
    {
        Debug.Log(tanque.gameObject.tag);
        if (tanque.gameObject.CompareTag("Player"))
        {
            MotorLau other = (MotorLau)tanque.gameObject.GetComponent(typeof(MotorLau));

            other.Destruir();
        }
    }
}
