using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string level_name;
	// Use this for initialization
	void Start () {
	}


	public void load()
	{
		Application.LoadLevel (level_name);
	}

	public void quit()
	{
		Debug.Log ("End game");
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
