using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{
    Light luz;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.magnitude > 1)
        {
            luz.intensity = transform.localScale.magnitude * 0.5f;
        }
        
    }
}
