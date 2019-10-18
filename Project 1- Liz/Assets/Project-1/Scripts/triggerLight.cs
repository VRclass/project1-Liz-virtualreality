using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLight : MonoBehaviour {
	public Light ligthToSwitch = null;

	public void OnTriggerEnter(Collider other) {
		print ("entered the trigger zone!");
		ligthToSwitch.enabled = false ;
	}

	public void OnTriggerExit(Collider other) {
		print ("exit the trigger zone!");
		ligthToSwitch.enabled = true ;
	}
}