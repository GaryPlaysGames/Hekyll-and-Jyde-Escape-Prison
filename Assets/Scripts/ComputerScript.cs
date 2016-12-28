using UnityEngine;
using System.Collections;

public class ComputerScript : MonoBehaviour {

	// Use this for initialization
	protected Animator animator;
	private KeyCode[] CONTROLS = {KeyCode.UpArrow, KeyCode.LeftArrow, 
		KeyCode.DownArrow, KeyCode.RightArrow};
	private int _controls = 0;
	public LaserSwitch[] myLaserSwitchArray;
	public bool canOperate = false;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.X))
		{
			canOperate = !canOperate;
		}
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if(canOperate && !other.GetComponent<RigidController>().getCrazy()) 
			{

				this.change_controls();
			}
		}
	}
	
	
	private void change_controls()
	{
		for(int c = 0; c < CONTROLS.Length && c < myLaserSwitchArray.Length; c++)
		{
			if(Input.GetKey(CONTROLS[c]))
			{
				if(myLaserSwitchArray[c].killBool)
				{
					myLaserSwitchArray[c].turnOff();
					_controls++;
				}
				if(_controls >= myLaserSwitchArray.Length)
					animator.SetBool("unlock", true);
			}
		}
	}
}
