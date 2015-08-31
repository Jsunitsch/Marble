using UnityEngine;
using System.Collections;

public class DayNightChange : MonoBehaviour {
	
	private Transform sun;
	// Use this for initialization
	void Start () {
	
		sun = GameObject.Find("Sun").GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {


		if(sun == null)
		{
			return;
		}
		sun.Rotate (0.1f, 0, 0);


	}
}
