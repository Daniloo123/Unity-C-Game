using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public bool isGoal = false;
    public GameController GameController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            isGoal = true;
            Debug.Log("You've hit the goal!");
            Destroy(other.gameObject);
            GameController.IncreaseScore();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            isGoal = false;
            Debug.Log("You've missed the goal!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") && isGoal)
        {
            Debug.Log("You've scored a goal!");
        }
    }
}
