using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kojo : Person
{
    
    void Start()
    {
        familyMembers[0] = "Kwame";
    }
    void Update() {
        Walk();
        Talk();
    }
}
