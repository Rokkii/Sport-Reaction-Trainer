using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButton : MonoBehaviour
{

    [SerializeField]
    private Button[] buttonArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomButtonPicker()
    {
        int indexNumber = Random.Range(0, buttonArray.Length);

        Debug.Log((buttonArray[indexNumber].name));

        buttonArray[indexNumber].GetComponent<Image>().color = Color.yellow;
    }

    public void ResetButtons()
    {
        for (int i = 0; i < buttonArray.Length; i++)
        {
            buttonArray[i].GetComponent<Image>().color = Color.grey;
        }
    }
}
