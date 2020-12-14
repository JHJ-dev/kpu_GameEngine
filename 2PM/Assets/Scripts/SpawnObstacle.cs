using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    
    private float spawnTimer = 0f;
    private Transform playerPos;

    private void Awake()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > 5f)
        {
            float randomX = Random.Range(-14f, 0f);
            Instantiate(obstacle, new Vector3(randomX, 0f, playerPos.position.z + 20f), Quaternion.Euler(-90f, 0, 0));
            spawnTimer = 0f;
        }
    }
}
