using UnityEngine;
using System.Collections;

public class DiabloMovement : MonoBehaviour {

	public CharacterController controller; // assign in inspector
	
	Vector3 destination;
	
	
	// Use this for initialization
	void Start () {
		destination = controller.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit rayHit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		
		
		if (Input.GetMouseButton(0) && Physics.Raycast(ray, out rayHit, 10000f) ){
			destination = rayHit.point;
			
			
	}
		
			Vector3 moveVector = destination - controller.transform.position;
			
			//Debug.DrawRay( controller.transform.position, moveVector );
			
			controller.SimpleMove(moveVector.normalized * 5f ); //controller.GetComponent<Movemotor>(speed);
			
	}
}

