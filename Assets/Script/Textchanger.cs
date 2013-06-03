using UnityEngine;
using System.Collections;

public class Textchanger : MonoBehaviour {
	
	TextMesh textMesh;
	Light mylight;
	public Transform destination;
	

	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh>();
		mylight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(transform.position, destination.position);
		
		textMesh.text = (destination.position - transform.position).ToString();
		
		transform.position += (new Vector3(0f,1f,0f) * Mathf.Sin (Time.time)) *Time.deltaTime;
		
		if(Time.time > 5f && GetComponent<AudioSource>().isPlaying == false )
			GetComponent<AudioSource>().Play (); 
		
		if(Time.time > 20f){
			mylight.enabled = false;
		}
	}
}
