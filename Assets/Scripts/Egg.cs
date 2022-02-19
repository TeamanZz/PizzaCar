using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject crackedEggPrefab;
    private void OnCollisionEnter(Collision other)
    {
        Terrain terrain;
        Track track;
        if (other.gameObject.TryGetComponent<Terrain>(out terrain) || other.gameObject.TryGetComponent<Track>(out track))
        {
            var crackedEgg = Instantiate(crackedEggPrefab, transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0), EggSpawner.Instance.crackedEggsContainer);
            Destroy(gameObject);
        }
    }
}