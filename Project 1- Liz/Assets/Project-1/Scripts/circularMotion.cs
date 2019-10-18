using System.Collections;
using UnityEngine;

public class circularMotion : MonoBehaviour {
		
	public float timeCounter = 0.0f;
	public float speed = 1.5f;
	public float width = 1.0f;
	public float height = 1.0f;

	void start(){
		// speed = .5;
		// width = .24;
		// height = .2;
	}

	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;

		float x = Mathf.Sin(timeCounter)*width*speed ;
		float y = Mathf.Sin(timeCounter)*height*speed  ;
		float z = Mathf.Cos(timeCounter)*width*speed  ;

		transform.Translate(x, 0, z, Space.Self);
		// transform.localPosition = new Vector3(x, y, z);
		// transform.position = new Vector3(x, y, z);
	}
}
