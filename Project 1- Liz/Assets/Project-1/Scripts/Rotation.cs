// Integrated Technology
// Created by Brenda Lopez for AR/VR class
// Recommended to review concepts from
// https ://docs.unity3d.com/ScriptReference/Transform.Rotate.html
// adjust the script to your own neeeds

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

public float howFast = 1.0f; // modify the value to match the needed speed

	void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(0, Time.deltaTime * howFast,  0); // play around to match the correct axis of rotation. Right now it should rotate around X axis

        // ...also rotate around the World's Z axis
        // commented out for experimentaion
        // transform.Rotate(0,  0, Time.deltaTime, Space.World);
    }
}
