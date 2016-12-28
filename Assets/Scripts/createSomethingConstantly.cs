using UnityEngine;
using System.Collections;

public class createSomethingConstantly : MonoBehaviour {

	private bool wait = true;
	public float speed = 10;
	public Rigidbody2D WhatToCreate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (wait) {
			StartCoroutine (doSomethingConstantly ());
			wait = false;
				}

		}


	 IEnumerator doSomethingConstantly(){
	
		if (wait) {
			yield return new WaitForSeconds (1);

			Rigidbody2D bulletInstance = Instantiate(WhatToCreate, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
			bulletInstance.velocity = new Vector2(-speed, 0);

			wait = true;
				}
	}
}
