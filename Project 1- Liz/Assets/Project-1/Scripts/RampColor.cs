// Integrated Technology
// Created by Brenda Lopez for AR/VR class
// Unity Scritping
// Basic scripts to get started with scripting in Unity 3D
// Feel free to edit and change as needed

using UnityEngine;
using System.Collections;

public class RampColor : MonoBehaviour {
	// Define the start and end color color with this public variable
	// accesible in the unity editor
	public Color colorStart = Color.red;
	public Color colorEnd = Color.green;
	public float duration = 1.0F;
	public Renderer rend;

	void Start() {
		rend = GetComponent<Renderer>();
	}
	void Update() {
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		
		// Line 26 is Commented out so you can experiment, and see the 
		// difference between the previous line and the next line of code
		// float lerp = Mathf.PingPong(Time.time, duration);

		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
	}
}