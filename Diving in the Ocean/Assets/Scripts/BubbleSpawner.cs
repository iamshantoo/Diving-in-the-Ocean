using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 3f;

    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnBubble();
            nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    void SpawnBubble()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), transform.position.y, 0f);
        Instantiate(bubblePrefab, spawnPosition, Quaternion.identity);
    }
}
