using UnityEngine;
using System.Collections;

public class PLATFORMER : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray ray = Camera.main.ScreenPointToRay (Input.GetButtonDown(KeyCode.Space));
		RaycastHit rayHit = new RaycastHit();
		
		if (Input.GetKeyDown(KeyCode.RightArrow)) 
			rigidbody.AddForce (Vector3.left);
		if (Input.GetKeyDown(KeyCode.LeftArrow))
			rigidbody.AddForce (Vector3.right);
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			if ( Physics.Raycast (Ray, out RaycastHit)) {
			rigidbody.AddForce (Vector3.up);
			}		
	}
}
