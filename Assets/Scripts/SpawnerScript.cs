using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnDelay = 0.85f;
    public GameObject carPrefab;
    private float nextTimetoSpawn;

    // Update is called once per frame
    void Update()
    {
        if(nextTimetoSpawn <= Time.time)
        {
            SpawnCar();

            nextTimetoSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        Instantiate(carPrefab, transform.position, transform.rotation);
    }
}
