using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] hazards;

    public Transform[] spawnPoints;

    public float timeBetweenSpawns;
    float nextSpawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            
            Transform randomSpawnPoint = spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Length)];
            GameObject randomHazard = hazards[UnityEngine.Random.Range(0, hazards.Length)];
            Instantiate(randomHazard, randomSpawnPoint.position, randomSpawnPoint.rotation);
            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }
}
