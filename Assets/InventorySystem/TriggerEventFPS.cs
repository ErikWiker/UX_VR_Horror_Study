using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventFPS : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject[] inventoryIcons;
	public bool bool1 = false;
	public bool bool2 = false;
	public bool bool3 = false;
	public GameObject i1 = null;
	public GameObject i2 = null;
	public GameObject i3 = null;

	public void OnTriggerEnter(Collider other)
	{
		
		if (other.CompareTag ("key1")) 
		{
			Debug.Log ("key1 Collision!");

			i1 = Instantiate(inventoryIcons[0]);
			i1.transform.SetParent(inventoryPanel.transform);
			bool1 = true;
			Destroy (other.gameObject);
		}

		if (other.CompareTag ("key2")) 
		{
			Debug.Log ("key2 Collision!");
			i2 = Instantiate(inventoryIcons[1]);
			i2.transform.SetParent(inventoryPanel.transform);
			bool2 = true;
			Destroy (other.gameObject);
		}

		if (other.CompareTag ("key3")) 
		{
			Debug.Log ("key3 Collision!");
			Debug.Log (bool3 );
			//i3 = Instantiate(inventoryIcons[2]);
			//i3.transform.SetParent(inventoryPanel.transform);
			bool3 = true;
			Debug.Log (bool3 );
			Destroy (other.gameObject);
		}

		if (other.CompareTag ("door1")) 
		{
			Debug.Log ("door1 Collision!");
			//Destroy (i1);
		}

		if (other.CompareTag ("door2")) 
		{
			Debug.Log ("door2 Collision!");
			//Destroy (i2);
		}

		if (other.CompareTag ("door3")) 
		{
			Debug.Log ("door3 Collision!");
			//Destroy (i3);
		}


	}
}
