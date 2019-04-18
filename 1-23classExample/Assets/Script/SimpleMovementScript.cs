using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * movementSpeed, 0, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
    //   transform.Translate(x,y,z);
         transform.Translate(Input , y , Input);
         transform.Translate(Input.GetAxix("Horizontal") * movementSpeed, 0, Input.GetAxis("Vertical")* movementSpeed);


    }
}
