using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePizza : MonoBehaviour
{
    public GameObject pizza;
    public Transform firePos;

    public Transform dir;
    Vector3 _dir;

    float coolTime = 1.0f;

    void Start()
    {

    }

    void Update()
    {
        if (coolTime > 0)
            coolTime -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
            if (coolTime < 0)
            {
                Instantiate(pizza, firePos.position, dir.rotation);
                coolTime = 1.0f;
            }
        _dir = new Vector3(dir.position.x - firePos.position.x, dir.position.y - firePos.position.y, dir.position.z - firePos.position.z).normalized;

        pizza.transform.forward += _dir;
    }
}