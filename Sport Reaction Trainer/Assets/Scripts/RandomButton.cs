using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButton : MonoBehaviour
{

    [SerializeField]
    private Button[] buttonArray;

    // On start, pick a random game button to activate
    private void Start()
    {
        RandomButtonPicker(); 
    }

    // Pick a random game button from an array of buttons
    public void RandomButtonPicker()
    {
        int indexNumber = Random.Range(0, buttonArray.Length);

        Debug.Log((buttonArray[indexNumber].name)); // Print game button selected to console, for debugging

        buttonArray[indexNumber].GetComponent<Image>().color = Color.yellow; // Set chosen game button colour to yellow

        buttonArray[indexNumber].GetComponent<ButtonPicked>().enabled = true; // Set ButtonPicked script (controls point scoring) on chosen game button to active
    }

    // Reset all game buttons colour to grey (debugging use)
    public void ResetButtons()
    {
        for (int i = 0; i < buttonArray.Length; i++)
        {
            buttonArray[i].GetComponent<Image>().color = Color.grey;
        }
    }
}
