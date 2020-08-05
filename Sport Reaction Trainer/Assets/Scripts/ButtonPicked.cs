using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPicked : MonoBehaviour
{

    [SerializeField]
    private Button currentButton;

	void Start()
	{
		Button btn = currentButton.GetComponent<Button>();

		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{

		if (currentButton.GetComponent<ButtonPicked>().enabled == true)
		{
			ScoreBoard.currentScore += 100;
		}

		currentButton.GetComponent<Image>().color = Color.grey;

		currentButton.GetComponent<ButtonPicked>().enabled = false;
	}
}
