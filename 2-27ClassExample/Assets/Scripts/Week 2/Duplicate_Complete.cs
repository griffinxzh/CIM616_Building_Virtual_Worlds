using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate_Complete : MonoBehaviour
{
    public GameObject prefab;
    public Transform origin;

    // Start is called before the first frame update
    void Start()
    {
    //   Instantiate(prefab, origin.position, origin.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab, origin.position, origin.rotation, origin); 
        }
        
    }
}
