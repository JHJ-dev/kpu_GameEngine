using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject, 0.3f);
        }
        if (collision.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "MovingObstacle")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Building")
        {
            Destroy(gameObject);
        }
        Destroy(gameObject, 5.0f);
    }
}
