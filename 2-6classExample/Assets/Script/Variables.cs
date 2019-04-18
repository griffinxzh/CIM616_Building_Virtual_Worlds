using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //typical data types
    public int Age;
    public float Height;
    public bool isHappy;
    public string firstName;

    //unity data types
    public GameObject player;
    public Transform playerPosition;
    public Animator playerAnimation;
    public Rigidbody playerPhysics;




    // Start is called before the first frame update
    void Start()
    {
        playerPhysics.useGravity = false;
        playerPosition.position = new Vector3(0, 3.0f, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
