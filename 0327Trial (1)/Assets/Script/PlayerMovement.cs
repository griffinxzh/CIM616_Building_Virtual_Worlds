
using UnityEngine;



public class PlayerMovement : MonoBehaviour
   

{

    public Rigidbody RB;
    public int playerMoveSpeed = 1000;


    void FixedUpdate()
    {
      //  RB.AddForce(0, 0, sideMoveSpeed * Time.deltaTime);

    if (Input.GetKey("d")) {
        RB.AddForce (playerMoveSpeed * Time.deltaTime, 0, 0);
    
    }

        if (Input.GetKey("a"))
        {
            RB.AddForce(-playerMoveSpeed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("w"))
        {
            RB.AddForce( 0, 0, playerMoveSpeed * Time.deltaTime);

        }
        if (Input.GetKey("s"))
        {
            RB.AddForce( 0, 0, -playerMoveSpeed * Time.deltaTime);

        }

    }
}
