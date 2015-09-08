using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject player;
	
	private Vector3 offset;
	

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = player.transform.position + offset;

		if (Input.GetKey ("q")) {
			transform.RotateAround (player.transform.position, Vector3.up, 0.5f);
			offset = transform.position - player.transform.position;

		} else if (Input.GetKey ("e")) {
			transform.RotateAround (player.transform.position, Vector3.down, 0.5f);
			offset = transform.position - player.transform.position;
		}


	}
}
