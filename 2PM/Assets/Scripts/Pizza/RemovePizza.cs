using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePizza : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Building")
        {
            Destroy(gameObject);
        }
    }
}
