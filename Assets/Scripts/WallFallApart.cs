using UnityEngine;
using System.Collections;

public class WallFallApart : MonoBehaviour {
	public GameObject WallFragment;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.tag == "Ball") 
		{
			Debug.Log("asdf");
			Rigidbody2D x = Instantiate(WallFragment, transform.position, transform.rotation) as Rigidbody2D;
			Destroy(gameObject);
			Destroy(x, 3f);
		}
	}

}
