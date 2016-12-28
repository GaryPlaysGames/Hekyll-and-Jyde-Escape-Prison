using UnityEngine;
using System.Collections;

public class CancelKinematic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col) {
		
		// If it hits an enemy...
		if (col.tag == "Player") {

			
			// Destroy the rocket.
			GetComponent<Rigidbody2D>().isKinematic = false;

		}
	}

}
