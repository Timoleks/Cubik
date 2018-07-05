using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public gmm gameManager;

	void OnTriggerEnter() {
		gameManager.CompleteLevel();
	}
}
