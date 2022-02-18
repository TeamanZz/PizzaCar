using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public int spawnEggsCount;
    public Transform spawnPoint;
    public GameObject eggPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEggs());
    }

    private IEnumerator SpawnEggs()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < spawnEggsCount; i++)
        {
            var newEgg = Instantiate(eggPrefab, spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
