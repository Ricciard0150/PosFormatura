using UnityEngine;

public class FinishSpawner : MonoBehaviour
{
    public GameObject finishPrefab;
    public float tempoParaSpawn = 60f;

    bool jaSpawnou = false;

    void Update()
    {
        if (!jaSpawnou && Time.timeSinceLevelLoad >= tempoParaSpawn)
        {
            Spawn();
            jaSpawnou = true;

            GameSpawn.chegouFinal = true;
        }
    }

    void Spawn()
    {
        Vector3 pos = new Vector3(0, 6f, 0);
        Instantiate(finishPrefab, pos, Quaternion.identity);
    }
}