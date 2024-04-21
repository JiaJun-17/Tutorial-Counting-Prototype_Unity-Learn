using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spherePrefabs;
    private float spawnRangeZ_left = -12.0f;
    private float spawnRangeZ_right = 12.0f;
    private float spawnPositionY_bottom = -1.0f;
    private float spawnPositionY_top = 18.0f;
    private float spawnInterval = 5.0f;
    private float startDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSphere()
    {
        Vector3 spawnPosition = new Vector3(0, spawnPositionY_top, Random.Range(spawnRangeZ_left, spawnRangeZ_right));
        Instantiate(spherePrefabs[0], spawnPosition, spherePrefabs[0].transform.rotation);
    }
}
