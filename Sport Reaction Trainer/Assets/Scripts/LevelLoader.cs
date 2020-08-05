﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void ChangeScene(string loadLevelName)
    {
        SceneManager.LoadScene(loadLevelName);
    }
}