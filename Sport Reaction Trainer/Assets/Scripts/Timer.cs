using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public float secondsLeft = 30;
    public string loadLevelName;

    // Initially print seconds left to text string
    void Start()
    {
        textDisplay.GetComponent<Text>().text = secondsLeft.ToString("0.0");
    }

    // Whilst there is time remaining, minus from secondsLeft until reaching 0 and display as text
    void Update()
    {
        if (secondsLeft >= 0)
        {
            secondsLeft -= 1 * Time.deltaTime;

            textDisplay.GetComponent<Text>().text = secondsLeft.ToString("0.0");
        }
        else
        {
            TimeOut();
        }
    }

    // Change scene when player runs out of time
    public void TimeOut()
    {
        Debug.Log("You are out of time");

        SceneManager.LoadScene(loadLevelName);
    }
}
