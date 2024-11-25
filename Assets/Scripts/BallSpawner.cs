using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnRadius = 5f;
    public int ballCount = 0;

    void Start()
    {
        SpawnBall();
    }

    void Update()
    {
        // Check if the current ball is destroyed
        ballCount = FindObjectsOfType<Ball>().Length;
        if (ballCount == 0)
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        // Generate a random position within the spawn radius
        Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        spawnPosition.y = 0f; // Ensure the ball spawns at ground level

        // Instantiate the ball prefab at the random position
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }
}
