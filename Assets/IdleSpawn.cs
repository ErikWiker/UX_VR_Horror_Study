using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleSpawn : MonoBehaviour {


    public GameObject SpawnedPrefab;
    public GameObject SpawnLocation; 
	private bool trigger = false;

	
	public AudioClip clip;
	public AudioSource source;

	private IEnumerator OnTriggerEnter(Collider other)
	{
	

		
		if (other.CompareTag("Player")  && trigger == false)
		{
			trigger = true;


			source.PlayOneShot(clip);
			Debug.Log("Trigger Idle");
			
			SpawnedPrefab.SetActive(true);
			yield return new WaitForSeconds(10);
			SpawnedPrefab.SetActive(false);
         

		}

	}
}
