using UnityEngine;

public class ObstacleSpwaner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float tempoSpawn = 2f;
    public float limiteX = 2.5f;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, tempoSpawn);
    }

    void Spawn()
    {
        float randomX = Random.Range(-limiteX, limiteX);
        Vector3 pos = new Vector3(randomX, transform.position.y, 0);

        Instantiate(obstaclePrefab, pos, Quaternion.identity);
    }
}