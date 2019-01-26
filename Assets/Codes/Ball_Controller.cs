using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

	public AudioSource[] audioClips = null;
  public GameObject rockGameObject;
  public Sprite rockImageSprite;

	private Rigidbody rb;
  private float speed_ball = 8f;
  private SpriteRenderer spr_rockImg;
  private bool hitLeftMonkey = false;

	// Use this for initialization
	void Start () {

    spr_rockImg = rockGameObject.AddComponent<SpriteRenderer>();

    if (spr_rockImg.sprite == null) {
      spr_rockImg.sprite = rockImageSprite;
    }

    rb = GetComponent<Rigidbody>();
		StartCoroutine(Pause());
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x < -25f) {

			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			Scoreboard_Controller.instance.GivePlayerTwoPoint();

      Player_Input_Controller.instance.hitLeft = false;
      Player_Input_Controller.instance.hitRight = false;

      speed_ball = 8f;

			StartCoroutine(Pause());

		}

		if (transform.position.x > 25f ) {

			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			Scoreboard_Controller.instance.GivePlayerOnePoint();

      Player_Input_Controller.instance.hitLeft = false;
      Player_Input_Controller.instance.hitRight = false;

      speed_ball = 8f;

			StartCoroutine(Pause());

		}
    
    if (hitLeftMonkey) {
      RotateLeft();
    }
    else {
      RotateRight();
    }

  }


	IEnumerator Pause () {

		yield return new WaitForSeconds(2.5f);
		LaunchBall();

	}


	void LaunchBall () {

		int xDirection = Random.Range(0,2);
		int yDirection = Random.Range(0,3);

		Vector3 launchDirection = new Vector3();

		if (xDirection == 0) {
			launchDirection.x = -8f;
		}

		if (xDirection == 1) {
			launchDirection.x = 8f;
		}

		if (yDirection == 0) {
			launchDirection.y = -8f;
		}

		if (yDirection == 1) {
			launchDirection.y = 8f;
		}

		if (yDirection == 2) {
			launchDirection.y = 0f;
		}

		rb.velocity = launchDirection;

	}


	void OnCollisionEnter(Collision hit) {

		if (hit.gameObject.name == "TopBounds") {

			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f) 
				speedInXDirection = speed_ball;
			
			if (rb.velocity.x < 0f)
				speedInXDirection = -speed_ball;
			

			rb.velocity = new Vector3(speedInXDirection, -8f, 0f);

		}

		if (hit.gameObject.name == "BottomBounds") {

			float speedinXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedinXDirection = speed_ball;

			if (rb.velocity.x < 0f)
				speedinXDirection = -speed_ball;
					
			rb.velocity = new Vector3(speedinXDirection, 8f, 0f);
		}


		if (hit.gameObject.name == "Left_Monkey") {
			
			rb.velocity = new Vector3(speed_ball, 0f, 0f);

			Player_Input_Controller.instance.hitLeft = true;
			Player_Input_Controller.instance.hitRight = false;

			if (!audioClips[0].isPlaying)
				audioClips[0].Play();

			if(transform.position.y - hit.gameObject.transform.position.y < -1)
				rb.velocity = new Vector3(speed_ball, -8f, 0f);


			if(transform.position.y - hit.gameObject.transform.position.y > 1)
				rb.velocity = new Vector3(speed_ball, 8f, 0f);

      speed_ball += (speed_ball * 0.01f) + (speed_ball / 2f);

      hitLeftMonkey = true;

		}

		if (hit.gameObject.name == "Right_Monkey") {

			rb.velocity = new Vector3(-speed_ball, 0f, 0f);

			Player_Input_Controller.instance.hitLeft = false;
			Player_Input_Controller.instance.hitRight = true;

			if (!audioClips[1].isPlaying)
				audioClips[1].Play();

			if(transform.position.y - hit.gameObject.transform.position.y < -1)
				rb.velocity = new Vector3(-speed_ball, -8f, 0f);


			if(transform.position.y - hit.gameObject.transform.position.y > 1)
				rb.velocity = new Vector3(-speed_ball, 8f, 0f);

      speed_ball += (speed_ball * 0.001f) + (speed_ball / 2f);

      hitLeftMonkey = false;

    }

	}

  void RotateLeft () {
    spr_rockImg.transform.Rotate(Vector3.forward); 
  }

  void RotateRight () {
    spr_rockImg.transform.Rotate(Vector3.back);

  }

}
