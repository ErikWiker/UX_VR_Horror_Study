using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject Destination;
    private Transform location;

    private void Awake()
    {
        location = Destination.GetComponent<Transform>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Only happens once
            if (this.enabled)
            {
                this.enabled = false;
                other.transform.position =  location.position;
                Debug.Log("Triggered Teleporation");
            }
        }
    }
}

