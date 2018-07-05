using UnityEngine;

public class CollisionScript : MonoBehaviour {

  public Script movement;

	void OnCollisionEnter (Collision collisionInfo){
		if(collisionInfo.collider.tag == "Obstacle"){
			movement.enabled = false;
      FindObjectOfType <gmm>().EndGame();

		}

 }
}
