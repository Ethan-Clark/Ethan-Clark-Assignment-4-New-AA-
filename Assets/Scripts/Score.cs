
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text text;
    public static int highscore = 0;
    public static int lastscore = 0;

    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {

        PlayerPrefs.SetInt("Score", PinCount);
        if (PinCount > highscore)
        {
            highscore = PinCount;
        } 
        if (PinCount > 1)
        {
           lastscore = PinCount;
        }

        PlayerPrefs.SetInt("HighScore", highscore);
        text.text = PinCount.ToString();
        PlayerPrefs.SetInt("LastScore", lastscore);
        text.text = PinCount.ToString();
    }
}

