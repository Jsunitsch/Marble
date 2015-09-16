using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	PlayerControl pl;
	// Use this for initialization
	void Start () {
		pl = this.GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Ground") {

			Debug.Log("Game over");
			Application.LoadLevel("fell from to high");
		}
	}
	
}
