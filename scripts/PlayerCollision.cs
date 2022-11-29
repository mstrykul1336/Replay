using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	public playermovement movement;     // A reference to our PlayerMovement script

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<gamemanager>().EndGame();
		}
		else if (collisionInfo.collider.tag == "secret")
		{
			 Debug.Log("tree");
			movement.enabled = false;   // Disable the players movement.
			SceneManager.LoadScene(5);
		}
	}

}
