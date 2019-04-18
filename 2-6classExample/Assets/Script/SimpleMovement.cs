using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{

    public float _speed;
    public float _horizontalInput;
    public float _verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        _speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal"); //it's a float
        _verticalInput = Input.GetAxis("Vertical");


        // transform.Translate(x,0, 0);  // move x direction
        //transform.Translate(Vector3.forward);

         transform.Translate(new Vector3(_horizontalInput, 0, _verticalInput) * _speed * Time.deltaTime);

        //  transform.Translate(1, 0, 0);


        //transform.Translate(1 * Time.deltaTime * _speed, 0, 0);

        //INPUT * SPEED * Time.deltaTime



    }
}
