using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovingObstacle : MonoBehaviour
{
    public GameObject movingobstacle;
    
    private float spawnTimer = 0f;
    private Transform playerPos;

    private void Awake()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > 10f)
        {
            float randomX = Random.Range(-10f, -4f);
            Instantiate(movingobstacle, new Vector3(randomX, 0f, playerPos.position.z + 100f), Quaternion.identity);
            spawnTimer = 0f;
        }
    }
}
