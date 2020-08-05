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

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = secondsLeft.ToString("0.0");
    }

    // Update is called once per frame
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

    public void TimeOut()
    {
        Debug.Log("You are out of time");

        SceneManager.LoadScene(loadLevelName);
    }
}
