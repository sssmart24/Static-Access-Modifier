using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{

 public Text scoreText;

 // Start is called before the first frame update
 void Start()
 {
 
 }

 private void Update(){

 // Update the displayed score with the value from the GameManager.

 scoreText.text = "Score" + GameManager.playerScore.ToString();
 }
}
