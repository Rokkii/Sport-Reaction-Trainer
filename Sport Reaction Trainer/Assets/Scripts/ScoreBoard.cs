using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    public static float currentScore = 0;

    [SerializeField]
    private Text scoreText;

    void Update()
    {
        scoreText.text = currentScore.ToString("0");  // outputs score as text string
    }

    public void ResetScore()
    {
        currentScore = 0;
    }
}
