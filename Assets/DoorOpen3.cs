using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen3 : MonoBehaviour
{
    public GameObject DespawnedPrefab;
    public GameObject SpawnedPrefab;
    public GameObject SpawnLocation; 
	bool doorOpen = false;

	private Animator animator;

	private AudioSource audioSource;
	private bool bool3;
	private bool bool4;
	private bool doorSound;
	void Start()
	{

		audioSource = GetComponent<AudioSource>();
		animator = GetComponent<Animator>();
		doorSound = false;

	}

	private IEnumerator OnTriggerEnter(Collider other)
	{
		bool3 = GameObject.Find ("TrackingSpace").GetComponent<TriggerEventFPS> ().bool3;
		bool4 = GameObject.Find ("Flashlight").GetComponent<TriggerEventFPS> ().bool3;
		
		if (other.CompareTag("Player") && (bool3==true || bool4==true))
		{
			doorOpen = true;

			Debug.Log("Triggered Door3 open");
			Debug.Log (bool3 );

			
			
			Debug.Log("Trigger collided with the player:door");
			
			SpawnedPrefab.SetActive(true);
            DespawnedPrefab.SetActive(false);

			Doors("Open");
			AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
			yield return new WaitForSeconds(3);

		}

	}

	// private void OnTriggerExit(Collider other)
	// {
	// 	if (other.CompareTag("Player"))
	// 	{

	// 		Debug.Log("Triggered Door3 close");

	// 		doorOpen = false;
	// 		Doors("Close");
	// 		AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
			

	// 	}

	// }

	void Doors(string direction)
	{
		animator.SetTrigger(direction);
	}

}


