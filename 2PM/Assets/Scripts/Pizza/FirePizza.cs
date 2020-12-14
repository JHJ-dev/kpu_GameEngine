using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePizza : MonoBehaviour
{
    public GameObject pizza;
    public Transform firePos;

    public Transform dir;
    Vector3 _dir;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Instantiate(pizza, firePos.position, dir.rotation);

        _dir = new Vector3(dir.position.x - firePos.position.x, dir.position.y - firePos.position.y, dir.position.z - firePos.position.z).normalized;

        pizza.transform.forward += _dir;
    }
}