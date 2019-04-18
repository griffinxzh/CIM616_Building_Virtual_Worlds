using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {   if (other.tag == "player")
        {
            print("The Player Touched the PowerUP :D ");

            Destroy(this.gameObject);


        }

    }

}





