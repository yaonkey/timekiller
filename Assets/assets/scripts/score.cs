using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public int HighScore;
    public int Score;
    public Text scoreDisplay;
    public Text HighscoreDisplay;

    public static score instance;

   public void Awake()
    {

        HighScore = PlayerPrefs.GetInt("SaveScore");


    }

  



    void Update()
    {
        scoreDisplay.text = "SCORE: " + Score.ToString();

        HighscoreDisplay.text = "HIGHSCORE: " + HighScore.ToString();

        if (Score > HighScore)
        {

            HighScore = Score;

            PlayerPrefs.SetInt("SaveScore", HighScore);


        }
    }



    public void SCORE()
    {

        HighScore = PlayerPrefs.GetInt("SaveScore");



    }

    public void kill()
    {

        Score++;
        

    }

    public void Reset()
    {

        PlayerPrefs.DeleteKey("SaveScore");
        Score = 0;
        HighScore = 0;

    }

}
