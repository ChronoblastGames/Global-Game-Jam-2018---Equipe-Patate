using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager 
{
    public static void LoadLevel(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }

    public static void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void LoadPreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public static void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
