using UnityEngine;
using System.Collections;

public class RigidController : MonoBehaviour {

	protected Animator animator;
	private float _up;		//jump height
	private float _speed;
	private bool _jump;
	private bool _crazy;	//false means small, true means big
	
	void Start () {
		_jump = false;
		_crazy = false;
		_up = 4f;
		_speed = 2f;
		animator = GetComponentInChildren<Animator>();
	}

	void Update () {
		Movement();				//MOONWALK BUG: HOLD LEFT AND RIGHT WHILE MOVING
		Attack ();
		Action();
		Transformation();
	}

	void Action() {
		if(Input.GetKeyDown(KeyCode.X))
		{
			if(_crazy)
			{

			}
			else
			{

			}
		}
	}

	void Attack() {
		if(Input.GetKeyDown(KeyCode.C))
		{
			if(_crazy)
			{
				GameObject.Find("punch").GetComponent<AudioSource>().Play();
			}
			else
			{
				GameObject.Find("explosion").GetComponent<AudioSource>().Play();
			}
		}
	}

	void Transformation()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			_crazy = !_crazy;
			animator.SetBool("crazy", _crazy);
			//add a wait function so transform animation finishes *******************************
			if(_crazy)
			{
				_speed = 1.5f;
				_up = 2f;
			}
			else
			{
				_speed = 2f;
				_up = 4f;
			}
		}
	}

	void Movement()
	{
		if(Input.GetKey(KeyCode.Space) && !_jump)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x, _up, 0);
			_jump = true;
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector3(_speed, GetComponent<Rigidbody2D>().velocity.y, 0);
			animator.SetBool("moving", true);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector3(-(_speed), GetComponent<Rigidbody2D>().velocity.y, 0);
			animator.SetBool("moving", true);
		}
		if(GetComponent<Rigidbody2D>().velocity.x == 0)
			animator.SetBool("moving", false);
		if(GetComponent<Rigidbody2D>().velocity.y == 0)
			_jump = false;
	}
}

