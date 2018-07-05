using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public Vector3 offset;
	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset;
	}
}
