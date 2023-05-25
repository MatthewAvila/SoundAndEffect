using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstacle2Prefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 1;
    private float repeatRate = 5;
    private float startDelay2 = 4;
    private float repeatRate2 = 4;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnObstacle2", startDelay2, repeatRate2);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameover == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }

    void SpawnObstacle2()
    {
        if (playerControllerScript.gameover == false)
        {
            Instantiate(obstacle2Prefab, spawnPos, obstacle2Prefab.transform.rotation);
        }
    }
}
