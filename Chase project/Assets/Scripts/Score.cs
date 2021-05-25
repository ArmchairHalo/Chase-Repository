using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Public variable
    public Text scoreDisplay;

    // private variables 
    private int scoreValue = 0;

    // Function to add to the players score
    // not automatically called by unity - need to call it myself in my code 
    public void AddScore(int toAdd)
    {
        // update the numerical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        //update the display of the score based on the numerical 
        scoreDisplay.text = scoreValue.ToString();
    }
}
