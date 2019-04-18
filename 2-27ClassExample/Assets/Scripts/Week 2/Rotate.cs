using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform rotatingObject;
    public float speed = 10.333f;
    public int apples = 2;
    public string firstName = "Kojo";
    

    // Start is called before the first frame update
    void Start()
    {
   //     print("I'm being called.");
   //     Debug.Log("I'm being called by debug");
        //   rotatingObject = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    //    rotatingObject.Rotate(45*Time.deltaTime * speed, 0, 0);
    //  rotatingObject.Translate(Vector3.up);
    }
}
