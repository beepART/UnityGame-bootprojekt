using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    public int Score;
    public int MaxDucks;
    public Text ScoreText;



  void Update(){

      if(Score >= 1000){   
          YouWin();
      }
      if(MaxDucks == 3){
          YouLose();
      }

  }
  void YouWin(){
      ScoreText.text = "You Win!";
      Time.timeScale = 0f;
  }
    void YouLose(){
      ScoreText.text = "You Lose and the world to.";
      Time.timeScale = 0f;
  }
  private void OnTriggerEnter2D(Collider2D other){

      if(other.gameObject.transform.tag == "duck" ) {
           Destroy(other.gameObject);
           SubtractScore();
           MaxDucks++;
      }else if(other.gameObject.transform.tag == "trash" ){       
           Destroy(other.gameObject);
           AddScore();
      }
    
  }

  void SubtractScore(){
      Score--;
      ScoreText.text = Score.ToString();
  }

  void AddScore(){
      Score++;
      ScoreText.text = Score.ToString();
  }

}
