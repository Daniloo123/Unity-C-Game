using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameController GameController;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("hierrrr");
            // If the ball collides with the goal, increase the score
            GameController.IncreaseScore();
        }
    }
}
