using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    public static float currentScore = 0;

    [SerializeField]
    private Text scoreText;

    // Display current player score as text
    void Update()
    {
        scoreText.text = currentScore.ToString("0");  // Outputs score as text string
    }

    // Reset player score
    public void ResetScore()
    {
        currentScore = 0;
    }
}
