using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject fixedObstacle;
    public GameObject movingObstacle;
    
    private float fspawnTimer = 0f;
    private float mspawnTimer = 0f;
    private Transform playerPos;

    private void Awake()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        fspawnTimer += Time.deltaTime;
        mspawnTimer += Time.deltaTime;
        if (fspawnTimer > 2f)
        {
            float random_fX = Random.Range(-14f, -2f);
            Instantiate(fixedObstacle, new Vector3(random_fX, 0f, playerPos.position.z + 20f), Quaternion.Euler(-90f, 0, 0));
            fspawnTimer = 0f;
        }
        if (mspawnTimer > 10f)
        {
            float random_mX = Random.Range(-10f, -6f);
            Instantiate(movingObstacle, new Vector3(random_mX, 0f, playerPos.position.z + 100f), Quaternion.identity);
            mspawnTimer = 0f;
        }
    }
}
