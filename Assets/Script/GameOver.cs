using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	PlayerControl pl;
	UserInterface ui;
	// Use this for initialization
	void Start () {
		pl = this.GetComponent<PlayerControl>();
		ui = GameObject.Find ("UI").GetComponent<UserInterface> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Ground") {

			Debug.Log("Game over");

			pl.FreezeControl();
			ui.GameOver();
		}
	}
	
}
