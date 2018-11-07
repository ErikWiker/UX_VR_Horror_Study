using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {


    //public float num;
    //public GameObject trigger;
   // public GameObject SoundSourceObject;
    public AudioClip audioClip;
    public AudioSource source;
    private bool hasPlayed = false;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {

            if (hasPlayed == false)
            {
              //  trigger.SetActive(true);

                source.PlayOneShot(audioClip);
                Debug.Log("Trigger collided, sound played");
               
                hasPlayed = true;
            }

        


                
          

            }

        }
     
        
   
        
	
	
}
