using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {

		}			UnityEngine.XR.InputTracking.Recenter ();
	}
}
