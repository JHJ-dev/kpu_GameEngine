using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaControll : MonoBehaviour
{
    public float speed = 100.0f;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Building")
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 3.0f);
    }
}
