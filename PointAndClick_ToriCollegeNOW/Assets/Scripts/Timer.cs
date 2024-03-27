using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour
{
    //IN CLASS COLLEGE NOW MW

    //GLOBAL VARIABLES
    public float timeRemaining = 90;
    public bool timerIsRunning = false;

    public TextMeshProUGUI timeText; 

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else if (timeRemaining <= 0)
            {
                Debug.Log("time has run out!");
                timerIsRunning = false;
                timeRemaining = 0; 
            }
            //Debug.Log("timeRemaining = " + timeRemaining);
        }
        DisplayTime(); 
    }

    void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(timeRemaining/60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        //Debug.Log("minutes = " + minutes);
        //Debug.Log("seconds = " + seconds);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 

    }
}
