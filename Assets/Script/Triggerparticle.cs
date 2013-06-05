using UnityEngine;
using System.Collections;

public class Triggerparticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Ball")
			particleSystem.enableEmission = !particleSystem.enableEmission;
	
	}
	
	void OnTriggerExit() {
	}
	
}
