using UnityEngine;
using System.Collections;

public class Movemotor : MonoBehaviour {
	
	public float speed = 5f;
	public float turnRate = 5f;
	CharacterController controller;
	
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	if (Mathf.Abs( Input.GetAxis( "Vertical" ) ) > 0.1f){
			controller.SimpleMove(transform.forward * speed * Input.GetAxis( "Vertical" ) );
		}
		
		if (Mathf.Abs ( Input.GetAxis( "Horizontal" ) ) > 0.1f ) {
			transform.Rotate(0f, Input.GetAxis( "Horizontal" ) * turnRate, 0f );
		}
	}
}
