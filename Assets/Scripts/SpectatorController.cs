using UnityEngine;
using System.Collections;

//[ExecuteInEditMode]
public class SpectatorController : MonoBehaviour {

    //public Camera myCamera;
    [HideInInspector]
    public float yElevationBoost = 1;

    public float movementSpeed = 0.25f;

    public float mouseSensitivityX = 3F;
    public float mouseSensitivityY = 3F;

    float myGlobalRotationX = 0f;
    float myGlobalRotationY = 0F;

    bool bToggleOne = false;
    bool bToggleTwo = false;

	Vector3 unscaledLocalPositionLastFrame;

    void Awake() {
        // GetComponent<Camera>().transparencySortMode = TransparencySortMode.Orthographic;
    }

    void Start() {
        myGlobalRotationX = GetComponent<Transform>().eulerAngles.y;
        myGlobalRotationY = GetComponent<Transform>().eulerAngles.x;
		unscaledLocalPositionLastFrame = GetComponent<Transform> ().localPosition;
    }

    void Update() {
        if (Input.GetKeyDown("return")) {
            bToggleOne = !bToggleOne;
            //toggleAsInt = Mathf.Abs (toggleAsInt - 1);
        }
        if (Input.GetKeyDown("n")) {
            //bToggleTwo = !bToggleTwo;
        }

        if (!bToggleOne) {
            float moveStrafe = Input.GetAxis("Horizontal");
            float moveForwardBack = Input.GetAxis("Vertical");
            float moveUpDown = Input.GetAxis("Jump");
            //float moveUpDown = Input.GetAxis ("Space");

			transform.localPosition = unscaledLocalPositionLastFrame;

            Vector3 movement = new Vector3(moveStrafe, moveUpDown, moveForwardBack);
            movement *= movementSpeed;
		
            transform.Translate(movement);

			unscaledLocalPositionLastFrame = transform.localPosition;


            // The better solution which rotates the way we'd expect it to in a FPS
            //The rotation as Euler angles in degrees relative to the parent transform's rotation.

            // MouseX is side to side ... MouseY is up and down
            //transform.y rotates around, like side to side, transform.x rotates up and down

            // Method one gets the current rotation in degrees and adds in the input multiplied by the sensitivity, then assigns that back to the current rotation


            //	float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivityX;
            //	float rotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * mouseSensitivityY;
            //	transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);

            /*
                float rotateX = Input.GetAxis ("Mouse X");
                float rotateY = Input.GetAxis ("Mouse Y");
				
                rotateX *= mouseSensitivityX;
                rotateY *= mouseSensitivityY;
				
                transform.Rotate (-rotateY, rotateX, 0, Space.World);
            */


            // Method two stores the current rotation from last frame in global variables, adds in the input multiplied by the sensitivity, then assigns that back to the current rotation
            myGlobalRotationX += Input.GetAxis("Mouse X") * mouseSensitivityX;
            myGlobalRotationY += Input.GetAxis("Mouse Y") * mouseSensitivityY;
            transform.localEulerAngles = new Vector3(-myGlobalRotationY, myGlobalRotationX, 0);
            //transform.localRotation = new Vector3(-globalRotationY, globalRotationX, 0);


            /*
                float rotateX = Input.GetAxis ("Mouse X");
                float rotateY = Input.GetAxis ("Mouse Y");
				
                rotateX *= mouseSensitivityX;
                rotateY *= mouseSensitivityY;
				
                transform.Rotate (-rotateY, rotateX, 0, Space.World);
            */

            /*
            float rotateY = Input.GetAxis("Mouse X") * mouseSensitivityX;
            float rotateX = Input.GetAxis("Mouse Y") * mouseSensitivityY;
			
            quatRot *= Quaternion.Euler (-rotateX, rotateY, 0f);
            transform.localRotation = quatRot;
            */
        }
        else {

        }
		transform.localPosition = unscaledLocalPositionLastFrame;

		Vector3 tempPos = transform.localPosition;
		tempPos.y += yElevationBoost;
		transform.localPosition = tempPos;

    }
}


