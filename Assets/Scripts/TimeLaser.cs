using UnityEngine;
using System.Collections;

public class TimeLaser : MonoBehaviour {

	public float time;

	// Use this for initialization
	void Start () {
		StartCoroutine(Updator());
	}
	
	// Update is called once per frame
	void Update () {
		Updator();
	}

	IEnumerator Updator()
	{
		gameObject.GetComponent<Collider2D>().enabled = false;
		gameObject.GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(time);
		gameObject.GetComponent<Collider2D>().enabled = true;
		gameObject.GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(time);
		StartCoroutine(Updator());
	}
}
