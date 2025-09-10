using UnityEngine;

public class TireSpawner : MonoBehaviour
{
    public float spawnInterval;
    public GameObject tirePrefab;
    public Transform spawnLocation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnTire), 1f, spawnInterval);
    }

    void SpawnTire()
    {
        Instantiate(tirePrefab, spawnLocation.position, Quaternion.identity);
    }
}
