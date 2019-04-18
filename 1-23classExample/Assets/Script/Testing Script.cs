using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{

    int Age1;
    private int Age2;  // private: int can't be acess by other script/ vs public
    public int Age3;


    //Float
    private float distance1;
    public float distance2;

    // Strings
    public string firstName = "zihan";

    // Booleans
    public bool isDoorClosed = true;

    // Array of Strings
    public string[] familyMemebers;

    //Array of Floats
    public float[] measurements = { 1, 2, 3, 4, 5 };


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

   


    }
}
