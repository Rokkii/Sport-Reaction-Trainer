using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButton : MonoBehaviour
{

    [SerializeField]
    private Button[] buttonArray;

    private void Start()
    {
        RandomButtonPicker();
    }

    public void RandomButtonPicker()
    {
        int indexNumber = Random.Range(0, buttonArray.Length);

        Debug.Log((buttonArray[indexNumber].name));

        buttonArray[indexNumber].GetComponent<Image>().color = Color.yellow;

        buttonArray[indexNumber].GetComponent<ButtonPicked>().enabled = true;
    }

    public void ResetButtons()
    {
        for (int i = 0; i < buttonArray.Length; i++)
        {
            buttonArray[i].GetComponent<Image>().color = Color.grey;
        }
    }
}
