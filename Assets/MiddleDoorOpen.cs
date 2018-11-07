using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleDoorOpen : MonoBehaviour
{

	bool doorOpen = false;

	private Animator animator;

	private AudioSource audioSource;
	private bool bool2;
	void Start()
	{

		audioSource = GetComponent<AudioSource>();
		animator = GetComponent<Animator>();

	}

	private void OnTriggerEnter(Collider other)
	{
		//bool2 = GameObject.Find ("TrackingSpace").GetComponent<TriggerEventFPS> ().bool2;
		
		//if (other.CompareTag("Player") && (bool2 == true) )
		if (other.CompareTag("Player"))
		{

			Debug.Log("Triggered Door2 open");
			AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
			Debug.Log("Trigger collided with the player:door");
			doorOpen = true;
			Doors("Open");

		}

	}


	void Doors(string direction)
	{
		animator.SetTrigger(direction);
	}

}


