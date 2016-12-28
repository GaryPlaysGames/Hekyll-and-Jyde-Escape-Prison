using UnityEngine;
using System.Collections;

public class LaserSwitch : MonoBehaviour {

	public bool killBool = true;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (killBool) 
			{
				Application.LoadLevel(Application.loadedLevelName);
				//This kills the game
			}
		}
	}
	
	private void setBool(bool input)
	{
		killBool = input;
	}
	
	public void turnOff()
	{
		this.setBool (false);
		this.GetComponent<Renderer>().material.color = Color.clear;
		Destroy(this.GetComponent<Collider2D>());
	}
	
	private void turnOn()
	{
		this.setBool (true);
		this.GetComponent<Renderer>().material.color = Color.red;
	}
}
