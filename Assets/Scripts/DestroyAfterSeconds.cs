using UnityEngine;
using System.Collections;

public class DestroyAfterSeconds : MonoBehaviour {

	public int lifetime = 3;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, lifetime);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
