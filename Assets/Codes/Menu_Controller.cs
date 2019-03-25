using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{

  public Text tutorialText;
  public string[] tutorialContent;
  public Button btnNext, btnPrev;
  public Sprite[] sprites;
  public Sprite btnCheck;
  public Image imgTutorial, imgBtnCancel;

  private int i = 0;

  public
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update() {

    Scene currentScene = SceneManager.GetActiveScene();
    string sceneName = currentScene.name;

    if (sceneName == "Tutorial") { 
    
      if (tutorialText != null) {
        tutorialText.text = tutorialContent[i];
      }

      imgTutorial.sprite = sprites[i];

      if (i < tutorialContent.Length - 1) {

        btnNext.interactable = true;
        
      } else {

        btnNext.interactable = false;
      
      }


      if (i > 0) {

        btnPrev.interactable = true;

      } else {

        btnPrev.interactable = false;
      
      }

      if (i == tutorialContent.Length - 1) {
        imgBtnCancel.sprite = btnCheck;
      }

    }


  }

  public void StartGame() {
    SceneManager.LoadScene(0);
  }

  public void QuitGame() {
    Application.Quit();
  }

  public void NextContent() {

    if (i < tutorialContent.Length)
      i++;

  }

  public void PreviousContent() {

    if(i > 0)
      i--;

  }

}
