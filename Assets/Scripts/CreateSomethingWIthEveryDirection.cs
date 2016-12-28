using UnityEngine;
using System.Collections;

public class CreateSomethingWIthEveryDirection : MonoBehaviour {
	private bool wait = true;
	public float speed = 10;
	public Rigidbody2D WhatToCreate;
	public int NumberOfBulletPerSecond = 8;
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
			for (int i = 1; i <= NumberOfBulletPerSecond; i++){

			
			Rigidbody2D bulletInstance = Instantiate(WhatToCreate, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;

				Vector2 newvector = new Vector2(Mathf.Cos(2*i*Mathf.PI/NumberOfBulletPerSecond)*speed, Mathf.Sin(2*i*Mathf.PI/NumberOfBulletPerSecond)*speed);
			
			bulletInstance.velocity = newvector;
			
			wait = true;
			}
		}
	}
}
