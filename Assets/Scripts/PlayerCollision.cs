
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisioninfo){
		if (collisioninfo.collider.tag == "Obstacle") {
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame();

		}
		if (collisioninfo.collider.tag == "Cylinder") {
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame();

		}
	}
}
