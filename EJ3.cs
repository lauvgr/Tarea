using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{
    Light luz;
    Color azul = new Color(0, 0, 1);
    Color rojo = new Color(1, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (luz.intensity >= 0.25f && luz.intensity < 0.5f)
        {
            luz.color = azul;
        }
        if (luz.intensity >= 0.5f && luz.intensity < 0.75f)
        {
            luz.color = rojo;
        }
    }
}
