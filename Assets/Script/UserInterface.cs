using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour {

	public string level_name;
	public GameObject game_over;
	private int time;
	
	Text time_text;
	Text level_text;
	// Use this for initialization
	void Start () {
		time_text = GameObject.Find("UI/Interface/TimeText").GetComponent<Text> ();
		level_text = GameObject.Find ("UI/Interface/LevelText").GetComponent<Text> ();
		time = 0;

		if (level_text) {
			level_text.text = level_name;
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (time_text) {
			time = (int) Time.timeSinceLevelLoad;
			time_text.text = "Time : " +time + " s";
		}

	}

	public void GameOver()
	{
		time_text.gameObject.SetActive (false);
		game_over.SetActive (true);
		
	}
	
}
