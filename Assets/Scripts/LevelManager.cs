using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public List<string> levelNames = new List<string>();

    public void AddLevel(string levelName)
    {
        if (!levelNames.Contains(levelName))
        {
            levelNames.Add(levelName);
        }
        else
        {
            Debug.LogWarning("Level " + levelName + " already exists in the list.");
        }
    }

    public void RemoveLevel(string levelName)
    {
        if (levelNames.Contains(levelName))
        {
            levelNames.Remove(levelName);
        }
        else
        {
            Debug.LogWarning("Level " + levelName + " does not exist in the list.");
        }
    }

    public void LoadLevel(string levelName)
    {
        if (levelNames.Contains(levelName))
        {
            SceneManager.LoadScene(levelName);
        }
        else
        {
            Debug.LogWarning("Level " + levelName + " does not exist in the list.");
        }
    }

    public void LoadNextLevel()
    {
        int currentLevelIndex = levelNames.IndexOf(SceneManager.GetActiveScene().name);
        if (currentLevelIndex < levelNames.Count - 1)
        {
            SceneManager.LoadScene(levelNames[currentLevelIndex + 1]);
        }
        else
        {
            Debug.LogWarning("No next level available.");
        }
    }

    public void LoadPreviousLevel()
    {
        int currentLevelIndex = levelNames.IndexOf(SceneManager.GetActiveScene().name);
        if (currentLevelIndex > 0)
        {
            SceneManager.LoadScene(levelNames[currentLevelIndex - 1]);
        }
        else
        {
            Debug.LogWarning("No previous level available.");
        }
    }
}
