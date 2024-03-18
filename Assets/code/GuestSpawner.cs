using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject raverPrefab;
    [SerializeField] private LevelManager lm;
    [SerializeField] private Lock nextPoint;
    [Header("Attribute")]
    [SerializeField] private int toSpawn;
    [SerializeField] private bool stopSpawning;
    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnDelay;
    private int spawned = 0;
    void Start()
    {
        InvokeRepeating("SpawnItemRandom", spawnTime, spawnDelay);
    }

    void SpawnItemRandom(){
        if (nextPoint.locked == false && spawned < toSpawn){
            Instantiate(raverPrefab, transform.position, transform.rotation);
            spawned++;
        }

        if(stopSpawning){
            CancelInvoke("SpawnItemRandom");
        }
    }
}
