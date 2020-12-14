using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaControll : MonoBehaviour
{
    public float speed = 100.0f;

    public int score;
    public PrintScore pScore;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);

        pScore = GameObject.Find("Score").GetComponent<PrintScore>();
        
        score = 0;
    }

    void Update()
    {
        
        Destroy(gameObject, 3.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Building")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "DeliveryCube")
        {
            score = 100;
            pScore.score += score;
            Destroy(gameObject);
        }
    }
}
