using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    Renderer render;
    
    float t = 0;

    Color azul = new Color(0, 0, 1);
    Color rojo = new Color(1, 0, 0);
    Color morado = new Color(1, 0, 1);


    // Start is called before the first frame update
    void Start()
    {
        
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t>=0 && t < 3)
        {
            render.material.color = rojo;
        }
        if (t >= 3 && t < 6)
        {
            render.material.color = azul;
        }
        if (t >= 6)
        {
            render.material.color = morado;
        }
    }
}
