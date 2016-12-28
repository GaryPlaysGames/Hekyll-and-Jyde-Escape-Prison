#pragma strict

// Public variable 
public var speed : int = 10;
var bulletLife : float= 5.0f;

// Gets called once when the bullet is created
function Start () {  
    // Set the X velocity to make the bullet move upward
    rigidbody2D.velocity.x = speed;
 	Destroy(gameObject,bulletLife);
}

// Gets called when the object goes out of the screen
function OnBecameInvisible() {  
    // Destroy the bullet 
    Destroy(gameObject);
}