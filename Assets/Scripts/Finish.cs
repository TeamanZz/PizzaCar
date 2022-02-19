using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class Finish : MonoBehaviour
{
    public List<GameObject> finishParticles = new List<GameObject>();
    public GameObject successPanel;
    public GameObject music;
    public ArcadeKart arcadeKart;
    public Rigidbody carRB;

    private void OnTriggerEnter(Collider other)
    {
        CheckPointCollisionHandler kart;
        if (other.TryGetComponent<CheckPointCollisionHandler>(out kart))
        {
            for (int i = 0; i < finishParticles.Count; i++)
            {
                finishParticles[i].SetActive(true);
            }
            music.SetActive(false);
            StartCoroutine(EnableEndPanel());
        }
    }

    private IEnumerator EnableEndPanel()
    {
        yield return new WaitForSeconds(1);
        successPanel.SetActive(true);
        arcadeKart.enabled = false;
        carRB.isKinematic = true;
    }
}