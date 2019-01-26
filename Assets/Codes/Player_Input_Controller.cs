using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

	public GameObject monkeyLeft, monkeyRight, spriteLeft, spriteRight;
	public Sprite mkOne, mkOne_Hit, mkTwo, mkTwo_Hit;
	public bool hitRight, hitLeft = false;

	public static Player_Input_Controller instance;

	private SpriteRenderer sp_MkOne, sp_MkTwo;

	// Use this for initialization
	void Start () {

		instance = this; 

		sp_MkOne = spriteLeft.AddComponent<SpriteRenderer>();
		sp_MkTwo = spriteRight.AddComponent<SpriteRenderer>();

		if (sp_MkOne.sprite == null && sp_MkTwo.sprite == null) {
			sp_MkOne.sprite = mkOne;
			sp_MkTwo.sprite = mkTwo;
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		// Initial velocity when buttons are not pressed
		monkeyLeft.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
		monkeyRight.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);


		if (hitLeft) {
			sp_MkOne.sprite = mkOne_Hit;
		} else {
			sp_MkOne.sprite = mkOne;
		}

		if (hitRight) {
			sp_MkTwo.sprite = mkTwo_Hit;
		} else {
			sp_MkTwo.sprite = mkTwo;
		}



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
