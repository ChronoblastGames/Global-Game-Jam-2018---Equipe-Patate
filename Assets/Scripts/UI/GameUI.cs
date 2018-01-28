using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public static GameUI gameUi;

    [Header("Container")]
    public GameObject[] mainMenuUI;
    public GameObject fadeRefference;
    public GameObject introTextScreen;
    public bool playButtonPressed;

    public CameraFadeAttributes cam;

    private void Start()
    {
        if (SceneManager.sceneCount == 0) //Main Menu
        {
            fadeRefference.GetComponent<CameraFadeController>().StartFade(cam);
            playButtonPressed = false;

            for (int i = 0; i < mainMenuUI.Length; i++)
            {
                mainMenuUI[i].SetActive(true);
            }

        }
    }

    public void EnterIntroSequence()
    {
        playButtonPressed = true; 
        if (playButtonPressed)
        {
            cam.cameraFadeType = CAMERA_FADE_TYPE.OUT;
            fadeRefference.GetComponent<CameraFadeController>().StartFade(cam);

            for (int i = 0; i < mainMenuUI.Length; i++)
            {
                mainMenuUI[i].SetActive(false);
            }

            StartCoroutine("EnterGameplay");
        }
    }

    public void ExitGame()
    {
        print("Debug: Goodbye!");
        Application.Quit();
    }
    
    
    public IEnumerator EnterGameplay()
    {
        yield return new WaitForSeconds(3f);
        introTextScreen.SetActive(true);
        print("Debug: Loading...");
        yield return new WaitForSeconds(15f);
        print("Debug: Now in gameplay!");
        introTextScreen.SetActive(false);
        SceneManager.LoadScene(1); //Main 
    }



}
