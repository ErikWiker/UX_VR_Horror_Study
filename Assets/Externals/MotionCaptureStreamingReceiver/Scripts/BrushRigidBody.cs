using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BrushRigidBody : MonoBehaviour
{

    // drag the MocapReceiver object from your scene Heirarchy into this slot in the Inspector for this object
    public MotionCaptureStreamingReceiver mocapReceiver;

    // in the Inspector, type the name of the rigidbody you would like to correspond with this object
    public string rbName;
    public bool isButtonPressed = false;
    public bool isBrushUpAndDry = false;
    public bool testPaint = false; //used to set paint on when I odn't have the wand for testing purposes

    void Start()
    {
        // tell the MocapReceiver to call the GetWandPosition method from this script every time it gets new data for the rigidbody named in the first argument
        mocapReceiver.RegisterRigidBodyDelegate(rbName, GetWandPosition);
    }

    // this is the method that MocapReceiver will call when it gets new data for the rigidbody you named
    public void GetWandPosition(Vector3 position, Quaternion rotation)
    {
        transform.position = new Vector3(position.x, position.y + 0.0f, position.z);
        transform.rotation = rotation;
        CheckButton();
    }




    private int buttonPressedCount = 0; //used to prevent false positives
    private int buttonDepressedCount = 0;
    private int thresholdChangeValue = 10;

    public void CheckButton()
    {
       //  Debug.Log("Distance: " + Mathf.Abs(Vector3.Distance(transform.position, GetComponentInChildren<RigidBodyExample>().transform.position)));




        if (Mathf.Abs(Vector3.Distance(transform.position, GetComponentInChildren<RigidBodyExample>().transform.position) - 0.15f) < 0.075)
        {
            isButtonPressed = true;
            return;
        }
        else
        {
            isButtonPressed = false;
        }

        //Debug.Log ("list has: " + list.Count + " markers");
        /*    
            bool closeMarker = false;
            foreach (Vector3 marker in list)
            {
               // Debug.Log((Vector3.Distance(transform.position, marker) - 0.15f));
                if (Mathf.Abs(Vector3.Distance(transform.position, marker) - 0.15f) < 0.05)
                {
                    if (isButtonPressed)
                    {
                        buttonDepressedCount = 0;
                    }
                    else
                    {
                        buttonPressedCount += 1;
                        if (buttonPressedCount >= thresholdChangeValue)
                        {
                            isButtonPressed = true;
                            buttonPressedCount = 0;
                        }
                    }
                    return;
                }
            }
            buttonDepressedCount += 1;
            if (!isButtonPressed)
            {
                buttonPressedCount = 0;
            }
            else if (buttonDepressedCount >= thresholdChangeValue)
            {
                isButtonPressed = false;
                buttonDepressedCount = 0;
            }
            */
    }
    
}



