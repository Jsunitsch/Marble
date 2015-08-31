using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		float moveLR = Input.GetAxis ("Horizontal");
		float moveUD = Input.GetAxis ("Vertical");

		Vector3 move = new Vector3 (moveLR, 0.0f, moveUD);

		rb.AddForce (move * speed);
	}
}
