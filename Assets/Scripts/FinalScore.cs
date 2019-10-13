using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text displayScore;
    public Text displayHighScore;
    private int lastscore;
    private int highscore;
    
    void Start()
    {
        lastscore = Score.lastscore;
        highscore = Score.highscore;
       
        displayHighScore.text = "High Score: " + highscore;
        displayScore.text = "Last Score: " + lastscore;
    }

   
}
