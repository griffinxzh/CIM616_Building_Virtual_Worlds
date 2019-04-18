using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Debug.Log("Explosion!");
        }
    }









}
