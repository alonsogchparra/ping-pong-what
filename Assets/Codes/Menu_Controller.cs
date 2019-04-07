using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Controller : MonoBehaviour
{

  public Text tutorialText;
  public string[] tutorialContent;
  public Button btnNext, btnPrev;
  public Sprite[] sprites;
  public Sprite btnCheck;
  public Image imgTutorial, imgBtnCancel;

  public string[] tutorialContentSpanish = { 
    "Bienvenido a Ping Pong What!?",
    "Para controlar a los jugadores.",
    "El jugador uno se controla presionando el botón W (para subir) y S (para bajar).",
    "El jugador dos se controlar presionando el botón flecha hacia arriba (Para subir) y Flecha Abajo (Para bajar).",
    "Pendiente con la roca ira acumulando energía por cada golpe que reciba un jugador.",
    "El ganador sera el primero que llegue a 11 en su marcador.",
    "Suerte y que el mejor mono gane...disculpen que el mejor jugador sea el vencedor."
  };

  public string[] tutorialContentEnglish = {
    "Welcome to Ping Pong What!?",
    "To control the players",
    "The first player can be controlled pressing the W button (to move up) and the S button (to move down).",
    "The second player can be controlled pressing the Arrow up button (to move up) and the Arrow down button (to move down).",
    "Be careful with the rock. It will accumulate energy for each hit that a player receives.",
    "The winner will be the first one who gets 11 points.",
    "Good luck! And the best monkey wins!… Sorry! The best player be the champion."
  };

  public int language_choice = 0;

  public Text btnStart, btnExit, btnRematch, btnExit_One, playerWins;

  private int i = 0;


  public
  // Start is called before the first frame update
  void Start()
  {

    Scene currentScene = SceneManager.GetActiveScene();
    string sceneName = currentScene.name;

    if (sceneName == "StartGame") {

      btnStart.text = Language_Controller.language[Language_Controller.selectedLanguage]["Start"];
      btnExit.text = Language_Controller.language[Language_Controller.selectedLanguage]["Exit"];

    }

    if (sceneName == "PlayerOneWins") {

      btnRematch.text = Language_Controller.language[Language_Controller.selectedLanguage]["Rematch"];
      btnExit_One.text = Language_Controller.language[Language_Controller.selectedLanguage]["Exit"];
      playerWins.text = Language_Controller.language[Language_Controller.selectedLanguage]["Player One Wins"];

    }

    if (sceneName == "PlayerTwoWins") {

      btnRematch.text = Language_Controller.language[Language_Controller.selectedLanguage]["Rematch"];
      btnExit_One.text = Language_Controller.language[Language_Controller.selectedLanguage]["Exit"];
      playerWins.text = Language_Controller.language[Language_Controller.selectedLanguage]["Player Two Wins"];

    }

  }

  // Update is called once per frame
  void Update() {

    Scene currentScene = SceneManager.GetActiveScene();
    string sceneName = currentScene.name;

    if (sceneName == "Tutorial") {

      if (Language_Controller.selectedLanguage == "sp") {

        if (tutorialText != null) {

          tutorialText.text = tutorialContentSpanish[i];

        }

        imgTutorial.sprite = sprites[i];

        if (i < tutorialContentSpanish.Length - 1) {

          btnNext.interactable = true;

        }

        else {

          btnNext.interactable = false;

        }


        if (i > 0) {

          btnPrev.interactable = true;

        }

        else {

          btnPrev.interactable = false;

        }

        if (i == tutorialContentSpanish.Length - 1) {
          imgBtnCancel.sprite = btnCheck;
        }

      } else if (Language_Controller.selectedLanguage == "en") {

        if (tutorialText != null) {

          tutorialText.text = tutorialContentEnglish[i];

        }

        imgTutorial.sprite = sprites[i];

        //if (i < tutorialContent.Length - 1) {
        if (i < tutorialContentEnglish.Length - 1) {

          btnNext.interactable = true;

        }
        else {

          btnNext.interactable = false;

        }


        if (i > 0) {

          btnPrev.interactable = true;

        }
        else {

          btnPrev.interactable = false;

        }

        //if (i == tutorialContent.Length - 1) {
        if (i == tutorialContentEnglish.Length - 1) {

          imgBtnCancel.sprite = btnCheck;

        }

      }

    }

  }

  public void StartGame() {
    SceneManager.LoadScene(3);
  }

  public void QuitGame() {
    Application.Quit();
  }

  public void TutorialScene() {
    SceneManager.LoadScene(2);
  }

  public void NextContent() {
  
    if (language_choice == 1) {

      if (i < tutorialContentSpanish.Length)
        i++;

    } else {

      if (i < tutorialContentEnglish.Length)
        i++;

    }


  }

  public void PreviousContent() {

    if(i > 0)
      i--;

  }

}
