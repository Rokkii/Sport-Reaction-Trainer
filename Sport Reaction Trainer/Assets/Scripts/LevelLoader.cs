using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Change to specified scene when called
    public void ChangeScene(string loadLevelName)
    {
        SceneManager.LoadScene(loadLevelName);
    }

    // Quit game when called
    public void QuitGame()
    {
        Application.Quit();
    }
}
