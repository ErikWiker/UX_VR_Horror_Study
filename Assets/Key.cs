using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour 
{


	private AudioSource audioSource;


	void Start(){

		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		//transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

	public void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);

			//Debug.Log("Trigger collided with the player:key");

			Destroy (this.gameObject);
		}
	}



}