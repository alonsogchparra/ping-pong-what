using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Language_Controller : MonoBehaviour {

  public static Dictionary<string, Dictionary<string, string>> language = new Dictionary<string, Dictionary<string, string>>
  {
    {
      "en", new Dictionary<string, string>
      {
        {
          "Language", "English"
        },
        {
          "Start", "Start"
        },
        {
          "Exit", "Exit"
        },
        {
          "Player One Wins", "Player One Wins!!!"
        },
        {
          "Player Two Wins", "Player Two Wins!!!"
        },
        {
          "Rematch", "Rematch"
        }
      }
    },
    {
      "sp", new Dictionary<string, string>
      {
        {
          "Language", "Español"
        },
        {
          "Start", "Comenzar"
        },
        {
          "Exit", "Salir"
        },
        {
          "Player One Wins", "¡¡¡Jugador Uno Gana!!!"
        },
        {
          "Player Two Wins", "¡¡¡Jugador Dos Gana!!!"
        },
        {
          "Rematch", "Revancha"
        }

      }
    }
  };

  public static string selectedLanguage;

  public void SelectLanguage (int i) {

    selectedLanguage = i == 0 ? "en" : "sp";

    StartCoroutine(EnterStartGame());
    
  }

  IEnumerator EnterStartGame() {
    yield return new WaitForSeconds(1.5f);
    SceneManager.LoadScene(1);
  }


}
