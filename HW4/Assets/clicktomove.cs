using UnityEngine;
using System.Collections;

public class clicktomove : MonoBehaviour {
	
	public Transform Cube2
	public float closeDistance = 5f

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );
		RaycastHit rayHit = new RaycastHit()
		
	//always move toward destination, but only if we are far away
	if (Cube2) {
			
	Vector3 offset = other.position - transform.position;
    float sqrLen = offset.sqrMagnitude;
    if (sqrLen < closeDistance * closeDistance)
		rigidbody.Addforce (closeDistance, Vector3.Normalize);
	
	[CURSOR_RAYCAST] = Ray
	 if ( MonoBehaviour.OnMouseDown ) {
	if ( Physics.Raycast( [CURSOR_RAYCAST], out RaycastHit) ) {
	[DESTINATION] = RaycastHit;
	
			}	
	}
}
