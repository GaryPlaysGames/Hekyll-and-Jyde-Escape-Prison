using UnityEngine;
using System.Collections;

public class ShootAtSomeone : MonoBehaviour {
	private bool wait = true;
	public float speed = 10;
	public Rigidbody2D WhatToCreate;
	public float frequency = 1;
	public GameObject player;
	
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
			Vector2 direction = new Vector2(-gameObject.transform.position.x + player.transform.position.x, -gameObject.transform.position.y + player.transform.position.y);

			bulletInstance.velocity = direction.normalized*speed;

			
			wait = true;
		}
	}
}