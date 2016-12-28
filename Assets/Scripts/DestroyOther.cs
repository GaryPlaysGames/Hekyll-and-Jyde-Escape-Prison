using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour {

	public GameObject TargetObject;

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
			Destroy(TargetObject.gameObject);

		}
	}




}
