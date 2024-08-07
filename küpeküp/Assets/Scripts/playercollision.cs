using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMovement Movement;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.tag == "Obstacle" )
        {

            Movement.enabled = false;
            FindObjectOfType<GameManager>().gameover();
        }
    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        Debug.Log(collisioninfo.collider.name);

        if (collisioninfo.collider.tag == "Obstacle" )
        {

            Movement.enabled = false;
            FindObjectOfType<GameManager>().gameover();
        }
    }
}
