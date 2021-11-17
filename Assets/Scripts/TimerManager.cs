using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timeValue = 60;
    public Text TextToDisplay;    
    
    // Start is called before the first frame update
    void Start()
    {
        // Starts the timer automatically
        GameStateManager.timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStateManager.timerIsRunning)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                GameStateManager.timerIsRunning = false;
            }
            TimeToDisplay(timeValue);
        }                
    }

    void TimeToDisplay(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TextToDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        GameStateManager.timerSeconds = seconds;
    }
}
