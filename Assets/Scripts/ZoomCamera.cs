using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]

public class ZoomCamera : MonoBehaviour {
	// Use this for initialization
	public Camera camera;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		}
		void OnTriggerEnter2D(Collider2D col){
			if (col.tag == "Player"){
			Debug.Log("asdfasdfasddd");
			if (Time.frameCount < 5) {
//				camera.orthographicSize++;
//				camera.orthographic++;
//				camera.transform.position.z1;
				camera.fieldOfView +=10;
			}
			}
		}

}