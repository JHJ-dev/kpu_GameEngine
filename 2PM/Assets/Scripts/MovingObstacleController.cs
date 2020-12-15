using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleController : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject,0.1f);
        }
        if (collision.collider.tag == "Building")
        {
            Destroy(gameObject);
        }
        Destroy(gameObject, 10.0f);
    }
}
