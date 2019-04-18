using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerP;
    public Vector3 camPosition;

  
    //void Start()
    //{
        
    //}


    void Update()
    {
        transform.position = playerP.position + camPosition;


    }
}
