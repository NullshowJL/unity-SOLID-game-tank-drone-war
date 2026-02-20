using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DroneSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject dronePrefab;
    [SerializeField] private float startSpawnTime = 0.5f;
    [SerializeField] private float spawnInterval = 2f;

    private void OnEnable()
    {
        GameEvents.OnGameStarted += StartSpawn;
        GameEvents.OnGameOver += StopSpawn;
    }

    private void OnDisable()
    {
        GameEvents.OnGameStarted -= StartSpawn;
        GameEvents.OnGameOver -= StopSpawn;
    }

    private void StartSpawn()
    {
        InvokeRepeating(nameof(SpawnDrone), startSpawnTime, spawnInterval);
    }

    private void StopSpawn()
    {
        CancelInvoke(nameof(SpawnDrone));
    }

    private void SpawnDrone()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Transform point = spawnPoints[index];
        Instantiate(dronePrefab, point.position, point.rotation);
    }
}
