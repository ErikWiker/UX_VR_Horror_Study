using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen1 : MonoBehaviour
{

    bool doorOpen = false;

    private Animator animator;

    private AudioSource audioSource;
	private bool bool1;
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
		bool1 = GameObject.Find ("TrackingSpace").GetComponent<TriggerEventFPS> ().bool1;
		if (other.CompareTag("Player") && (bool1 == true) )
        {

            Debug.Log("Triggered Door1 open");


            AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
            Debug.Log("Trigger collided with the player:door");
            doorOpen = true;
            Doors("Open");

        }

    }

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{

			Debug.Log("Triggered Door1 close");

			doorOpen = false;
			Doors("Close");
			AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);

		}

	}

    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }

}


