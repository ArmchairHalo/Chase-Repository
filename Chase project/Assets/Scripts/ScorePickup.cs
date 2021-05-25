using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    // Public Variable
    // Editable in unity
    // Useable by other scripts 
    public int pickupValue = 1;

    // Called by unity when this object overlaps with another object marked as a trigger
    // this is the condition (if the player touches a collectable)
    void OnTriggerEnter2D(Collider2D other)
    {
        // check if the Score script is attached to the thing we bumped into 
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            // We have a scoreScript, so the thing we bumped into is the player!

            //add the pickup value to the players current score (actions)
            scoreScript.AddScore(pickupValue);

            // we should then delete this object so we dont infinitely add score
            Destroy(gameObject);
        }
    }

}
