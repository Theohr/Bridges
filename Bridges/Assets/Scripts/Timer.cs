using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    // reference to the text in the game
    public Text textBox;
    public float speed = 1;
    bool runningTimer = true;

    public GameObject completedMode;

    // Use this for initialization
    void Start()
    {
        // getting the component of the text box of the timer (00:00)
        textBox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // if the timer is running then we enter the if statement
        if (runningTimer)
        {
            if (completedMode.activeInHierarchy == false)
            {
                // timer increments 1 second per frame
                timeStart += Time.deltaTime * speed;
                // each minute are added every 59 seconds and goes up to 59 minutes
                string minutes = Mathf.Floor((timeStart % 3600) / 59).ToString("00");
                // each second gets increment up to 59 
                string seconds = (timeStart % 59).ToString("00");
                // text box displaying the timer in game
                textBox.text = minutes + ":" + seconds;
            }
        }
        else
        {
            gameObject.GetComponent<Timer>().enabled = false;
        }
    }
}
