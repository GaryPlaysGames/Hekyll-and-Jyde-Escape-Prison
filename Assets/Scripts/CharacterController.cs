using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	
	private bool _right;

	void Start () {
		_right = true;
	}

	void Update () {
		Flip();
	}

	void Flip(){
		if(Input.GetKeyDown(KeyCode.RightArrow) && !_right)
		{
			transform.Rotate(0, 180, 0);
			_right = true;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow) && _right)
		{
			transform.Rotate(0, 180, 0);
			_right = false;
		}
	}
}