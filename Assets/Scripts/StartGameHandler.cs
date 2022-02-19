using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameHandler : MonoBehaviour
{
    public GameObject startPanel;
    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.Mouse0))
            return;

        if (startPanel.activeSelf == true)
        {
            startPanel.SetActive(false);
            EggSpawner.Instance.StartSpawnEggs();
        }
    }
}