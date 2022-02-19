using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class TerrainCollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        ArcadeKart kart;
        if (other.gameObject.TryGetComponent<ArcadeKart>(out kart))
        {
            SceneHandler.Instance.RestartScene();
        }
    }
}
