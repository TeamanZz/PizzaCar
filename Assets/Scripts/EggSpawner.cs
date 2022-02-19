using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using KartGame.KartSystems;
public class EggSpawner : MonoBehaviour
{
    public static EggSpawner Instance;

    public int spawnEggsCount;
    public Transform spawnPoint;
    public Transform crackedEggsContainer;
    public GameObject eggPrefab;
    public ArcadeKart kart;
    public float timeUntilStart = 1;

    private void Awake()
    {
        Instance = this;
    }

    public void StartSpawnEggs()
    {
        StartCoroutine(SpawnEggs());
    }

    private IEnumerator SpawnEggs()
    {
        yield return new WaitForSeconds(1);
        transform.DOMoveY(5.5f, 1);
        yield return new WaitForSeconds(1);
        for (int i = 0; i < spawnEggsCount; i++)
        {
            var newEgg = Instantiate(eggPrefab, spawnPoint.position + new Vector3(Random.Range(-0.3f, 0.3f), 0, Random.Range(-0.3f, 0.3f)), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            yield return new WaitForSeconds(0.1f);
        }
        transform.DOMoveY(15f, 0.8f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(timeUntilStart);
        kart.enabled = true;
        kart.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.SetActive(false);
    }
}