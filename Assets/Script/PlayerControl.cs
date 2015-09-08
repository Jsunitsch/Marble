using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject my_cam;
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 controlDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		Vector3 actualDirection = my_cam.transform.TransformDirection(controlDirection);
		rb.AddForce ((actualDirection * speed) );
	}

	public void FreezeControl(){

		rb.constraints = RigidbodyConstraints.FreezeAll;
	}

}
