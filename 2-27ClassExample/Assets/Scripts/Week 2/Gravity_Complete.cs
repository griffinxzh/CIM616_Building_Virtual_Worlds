using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_Complete : MonoBehaviour
{
    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = rigid.GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
