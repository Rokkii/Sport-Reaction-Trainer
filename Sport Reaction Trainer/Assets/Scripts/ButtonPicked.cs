using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPicked : MonoBehaviour
{

    [SerializeField]
    private Button currentButton;

	[SerializeField]
	private RandomButton nextButton;

	void Start()
	{
		Button btn = currentButton.GetComponent<Button>();

		btn.onClick.AddListener(TaskOnClick);
	}

	// When the chosen button is clicked by the player, add points and reset the button to default state
	void TaskOnClick()
	{
		// Run if the ButtonPicked script has been enabled on the game button clicked by the player

		if (currentButton.GetComponent<ButtonPicked>().enabled == true)
		{
			ScoreBoard.currentScore += 100; // Add points when player clicks the activated button

			currentButton.GetComponent<Image>().color = Color.grey; // Reset the button from yellow to grey

			currentButton.GetComponent<ButtonPicked>().enabled = false; // Disable ButtonPicked script from the current chosen button

			nextButton.RandomButtonPicker(); // Pick another random game button to activate
		}
	}
}
