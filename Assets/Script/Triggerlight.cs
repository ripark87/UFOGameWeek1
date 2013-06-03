using UnityEngine;
using System.Collections;

public class Triggerlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Ball")
			light.enabled = !light.enabled;
	
	}
	
	void OnTriggerExit() {
	}
}
