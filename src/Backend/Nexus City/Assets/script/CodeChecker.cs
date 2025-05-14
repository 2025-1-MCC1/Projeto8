using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab;
    public Transform spawnPoint;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    void Start()
    {
        StartCoroutine(SpawnCarLoop());
    }

    IEnumerator SpawnCarLoop()
    {
        while (true)
        {
            SpawnCar();
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime);
        }
    }

    void SpawnCar()
    {
        if (carPrefab && spawnPoint)
        {
            Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogWarning("CarPrefab ou SpawnPoint não foram atribuídos no Inspector.");
        }
    }
}