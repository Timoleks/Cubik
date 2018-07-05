using UnityEngine;

public class Script : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = -2000f;
	public float sForce = 500f;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce * Time.deltaTime);
		if(Input.GetKey("d"))
		{
			rb.AddForce (sForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a"))
		{
			rb.AddForce(-sForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(rb.position.y < -1f)
		{
			FindObjectOfType <gmm>().EndGame();
		}
	}
}
