using UnityEngine;
using System.Collections;

public class NPCBot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
	
	//always walk forward, relative to where Im facing
	rigidbody.AddForce ( Vector3.forward );
	//detect if theres a wall ahead of me; turn left or right if there is
	if ( Physics.Raycast ( Vector3.forward, 10f)
		Random.Range (0f, 10f) 
		if ( Random.Range < 5 ) Transform.Rotate (Quaternion.Angle 90f)
		else Transform.Rotate ( Quaternion.Angle -90f);
	}
}
