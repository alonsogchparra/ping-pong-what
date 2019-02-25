using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{

  public void PlayersTurnNegative () {
    transform.localScale = new Vector3(-1f, 1f, 1f);
  }

  public void PlayersTurnPositive() {
    transform.localScale = new Vector3(1f, 1f, 1f);
  }

  public void ButtonChangeInColor () {
    this.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
  }

  public void TextChangeInColor () {
    this.GetComponent<Text>().color = new Color32(255, 255, 255, 255);
  }

  public void ButtonChangeOutColor()
  {
    this.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
  }

  public void TextChangeOutColor()
  {
    this.GetComponent<Text>().color = new Color32(0, 0, 0, 255);
  }
}
