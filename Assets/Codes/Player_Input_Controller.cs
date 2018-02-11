using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

	public GameObject monkeyLeft, monkeyRight;

	public static Player_Input_Controller instance;

	// Use this for initialization
	void Start () {

		instance = this;
		
	}
	
	// Update is called once per frame
	void Update () {

		// Initial velocity when buttons are not pressed
		monkeyLeft.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
		monkeyRight.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		// Input Keys for Player 1
		if (Input.GetKey(KeyCode.W)) {

			monkeyLeft.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);

		} else if (Input.GetKey(KeyCode.S)) {

			monkeyLeft.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);

		}

		// Input Keys for Player 2 
		if (Input.GetKey(KeyCode.UpArrow)) {

			monkeyRight.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);

		} else if (Input.GetKey(KeyCode.DownArrow)) {

			monkeyRight.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);

		}
				
	}
}
