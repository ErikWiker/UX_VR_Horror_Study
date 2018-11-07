using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuitGame : MonoBehaviour {


public Light lightToDim = null;




	
	


	private IEnumerator OnTriggerEnter(Collider other)
	{
		
		
		if (other.CompareTag("Player") )
		{

			lightToDim.intensity = 0;
		 	Debug.Log("Quit");
		 	yield return new WaitForSeconds(1);
         	//Application.Quit();
         	EditorApplication.isPlaying = false;
			

		}

	}
}
