using UnityEngine;
using VR = UnityEngine.VR;
using System.Collections;

public class RecenterOVR : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space") || Input.GetKeyDown("[0]")){
			Debug.Log("recentering OVR rotation");
			UnityEngine.XR.InputTracking.Recenter();
		}
	}
}
