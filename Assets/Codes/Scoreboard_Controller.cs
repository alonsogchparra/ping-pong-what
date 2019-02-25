using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard_Controller : MonoBehaviour {

	public static Scoreboard_Controller instance;

	public Text playerOneScoreText, PlayerTwoScoreText;
	public int playerOneScore, playerTwoScore;

	// Use this for initialization
	void Start () {

		instance = this;

		playerOneScore = playerTwoScore = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GivePlayerOnePoint () {

		playerOneScore += 1;
		playerOneScoreText.text = playerOneScore.ToString();

    if (playerOneScore > 10) {
      SceneManager.LoadScene(1);
    }


  }


	public void GivePlayerTwoPoint () {

		playerTwoScore += 1;
		PlayerTwoScoreText.text = playerTwoScore.ToString();

    if (playerTwoScore > 10) {
      SceneManager.LoadScene(2);
    }

  }


}
