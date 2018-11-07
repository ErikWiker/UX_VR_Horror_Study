using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlSpawn : MonoBehaviour {


    

    public GameObject SpawnedPrefab;
    public GameObject SpawnLocation; 
	private bool trigger = false;

	
	public AudioClip clip;
	public AudioSource source;
	private bool bool3;
	private bool bool4;


	private IEnumerator OnTriggerEnter(Collider other)
	{
		bool3 = GameObject.Find ("TrackingSpace").GetComponent<TriggerEventFPS> ().bool3;
		bool4 = GameObject.Find ("Flashlight").GetComponent<TriggerEventFPS> ().bool3;
		
		if (other.CompareTag("Player")  && trigger == false && (bool3==true || bool4==true))
		{
			trigger = true;

			Debug.Log("Triggered Door3 open");
			Debug.Log (bool3 );

			source.PlayOneShot(clip);
			Debug.Log("Trigger Crawl");
			
			SpawnedPrefab.SetActive(true);
			yield return new WaitForSeconds(3);
			SpawnedPrefab.SetActive(false);
         
			
			

		}

	}
}