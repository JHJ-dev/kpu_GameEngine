using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    private PlayerMoveController _playerMoveController;

    private void Awake()
    {
        _playerMoveController = GetComponent<PlayerMoveController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
        Destroy(gameObject, 5.0f);
    }
}
