//using UnityEngine;
//using System.Collections;
//
//public class RigidController : MonoBehaviour {
//
//
//
//	protected Animator animator;
//	private float _up;		//jump height
//	private float _speed;
//	private bool _jump;
//	private bool _crazy;	//false means small, true means big
//
//	//public ComputerScript[] compArray;
//	private bool canMove;
//	
//	void Start () {
//		_jump = false;
//		_crazy = false;
//		_up = 4f;
//		_speed = 2f;
//		animator = GetComponentInChildren<Animator>();
//		canMove = true;
//		//compArray = GameObject.FindGameObjectsWithTag ("Console");
//	}
//
//	void Update () {
//		Action();
//		if(canMove)
//		{
//			Movement();				//MOONWALK BUG: HOLD LEFT AND RIGHT WHILE MOVING
//		}
//		Attack ();
//		Transformation();
//	}
//
//	void Action() {
//		if(Input.GetKeyDown(KeyCode.X))
//		{
//			if(_crazy)
//			{
//
//			}
//			else
//			{
//				canMove = !canMove;
////				foreach(ComputerScript comp in compArray)
////				{
////					comp.canOperate = !comp.canOperate;
////				}
//			}
//		}
//	}
//
//	void Attack() {
//		if(Input.GetKeyDown(KeyCode.C))
//		{
//			if(_crazy)
//			{
//				GameObject.Find("punch").audio.Play();
//			}
//			else
//			{
//				GameObject.Find("explosion").audio.Play();
//			}
//		}
//	}
//
//	void Transformation()
//	{
//		if(Input.GetKeyDown(KeyCode.Z))
//		{
//			_crazy = !_crazy;
//			animator.SetBool("crazy", _crazy);
//			//add a wait function so transform animation finishes *******************************
//			if(_crazy)
//			{
//				_speed = 1.5f;
//				_up = 2f;
//			}
//			else
//			{
//				_speed = 2f;
//				_up = 4f;
//			}
//		}
//	}
//
//	void Movement()
//	{
//		if(Input.GetKey(KeyCode.Space) && !_jump)
//		{
//			rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, _up, 0);
//			_jump = true;
//			Debug.Log ("Jump");
//		}
//		if(Input.GetKey(KeyCode.RightArrow))
//		{
//			rigidbody2D.velocity = new Vector3(_speed, rigidbody2D.velocity.y, 0);
//			animator.SetBool("moving", true);
//		}
//		if(Input.GetKey(KeyCode.LeftArrow))
//		{
//			rigidbody2D.velocity = new Vector3(-(_speed), rigidbody2D.velocity.y, 0);
//			animator.SetBool("moving", true);
//		}
//		if(rigidbody2D.velocity.x == 0)
//			animator.SetBool("moving", false);
//		if(rigidbody2D.velocity.y == 0)
//			_jump = false;
//	}
//
//	public bool getCrazy()
//	{
//		return _crazy;
//	}
//	
//}
//
