
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

  void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Moving Obj")
        {
            Debug.Log("You collide an obstacle!");
            movement.enabled = false;



        }
    }
}
