using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwaySpawn : MonoBehaviour
{

    public GameObject DespawnedPrefab;
    public GameObject SpawnedPrefab;
    public GameObject SpawnLocation; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Only happens once
            if (this.enabled)
            {
                this.enabled = false;
                SpawnedPrefab.SetActive(true);
                DespawnedPrefab.SetActive(false);

                //Instantiate(SpawnedPrefab, SpawnLocation.transform.position, SpawnLocation.transform.rotation);
                //Destroy(DespawnedPrefab);
                Debug.Log("Triggered HallwaySpawner1");
            }
        }
    }
}
