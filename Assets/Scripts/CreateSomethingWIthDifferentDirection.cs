using UnityEngine;
using System.Collections;

public class CreateSomethingWIthDifferentDirection : MonoBehaviour {
	private bool wait = true;
	public float speed = 10;
	public Rigidbody2D WhatToCreate;
	public double RotatingSpeed = 0.5;
	public float frequency = 1;

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
			yield return new WaitForSeconds (1/frequency);
			
			Rigidbody2D bulletInstance = Instantiate(WhatToCreate, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
//			Debug.Log(Time.time/density);
			double x = Time.time/RotatingSpeed;
			float k = (float)x;
			Vector2 newvector = new Vector2(Mathf.Cos(k)*speed, Mathf.Sin(k)*speed);

			bulletInstance.velocity = newvector;
			
			wait = true;
		}
	}
}
