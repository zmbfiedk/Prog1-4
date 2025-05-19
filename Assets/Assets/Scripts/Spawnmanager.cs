using System.Collections;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    [SerializeField] private GameObject EvilSpawnprefab;
    [SerializeField] private Transform spawnpoint;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(2);
            Vector3 pos = spawnpoint.position + Vector3.right * i * 2;
            Instantiate(EvilSpawnprefab, pos, Quaternion.identity);
            Debug.Log("Eerste golf - Enemy " + i + " spawned.");
        }

        yield return new WaitForSeconds(5f);

        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(2);
            Vector3 pos = spawnpoint.position + Vector3.right * i * 2 + Vector3.forward * 3; 
            Instantiate(EvilSpawnprefab, pos, Quaternion.identity);
            Debug.Log("Tweede golf - Enemy " + i + " spawned.");
        }
    }
}
