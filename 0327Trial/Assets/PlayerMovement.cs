using UnityEngine;

public class PlayerMovement : MonoBehaviour



{
    public Rigidbody rb;


    void Start()
    {
        Debug.Log("Hello, World!");

    }

   
    void FixedUpdate()      // FixedUpdate is used for physics
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
