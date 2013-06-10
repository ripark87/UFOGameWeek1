using UnityEngine;
using System.Collections;

public class CapControl : MonoBehaviour {
	
	public float speed = 5f;
	public float turnRate = 5f;
	public float jumpHeight = 20f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool grounded = Physics.Raycast ( transform.position, -transform.up, 5.1f);
		
		if ( Input.GetButtonDown( "Jump" ) && grounded) {
			rigidbody.AddForce( transform.up * jumpHeight, ForceMode.Impulse );
		}
	
	}
	
	void FixedUpdate () {
		if (Mathf.Abs( Input.GetAxis( "Vertical" ) ) > 0.1f){
			rigidbody.AddForce( transform.forward * speed * Input.GetAxis( "Vertical" ) , ForceMode.VelocityChange );
		}
		
		if (Mathf.Abs ( Input.GetAxis( "Horizontal" ) ) > 0.1f ) {
			transform.Rotate(0f, Input.GetAxis( "Horizontal" ) * turnRate, 0f );
		}
		
		
	
	}
	
}
