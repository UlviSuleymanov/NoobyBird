using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int scoreIndex = 0;
   
    public void ResetScore()
    {
        scoreIndex = 0;
        score.text = "Score: " + scoreIndex;
       
    }

    public void SetScore(TextMeshProUGUI scoreBoard)
    {
        score = scoreBoard;
    }

    public void UpdateScoreUI(int scr)
    {
        scoreIndex = scr;
        score.text = scoreIndex.ToString();   
    }

  
}
