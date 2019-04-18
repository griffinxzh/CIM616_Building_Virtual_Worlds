using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_Test : MonoBehaviour
{
    public float rayDistance = 100f;


    // Update is called once per frame
    void Update()
    {
        
    }

    void Detection()
    {
        if (Physics.Raycast(transform.position, Vector3.forward, rayDistance))
        {

        }
    }
}
