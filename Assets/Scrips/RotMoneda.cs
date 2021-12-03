using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotMoneda : MonoBehaviour
{
    public float rot;
    
    void Start()
    {

    }

    
    void Update()
    {
        transform.Rotate(new Vector3(rot, 0, 0f) * Time.deltaTime);
    }
}
