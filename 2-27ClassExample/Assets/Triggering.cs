using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggering : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Entered the Trigger Zone");
        }
    }
}
