using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWheel : MonoBehaviour {

    public WheelCollider targetWheel;
    private Vector3 wheelPositiom = new Vector3();
    private Quaternion wheelRotation = new Quaternion();
	
	void Update ()
    {
        targetWheel.GetWorldPose(out wheelPositiom,out wheelRotation);
        transform.position = wheelPositiom;
        transform.rotation = wheelRotation;
	}
}
