using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
   
    [Header("Container")]
    public GameObject fadeRefference;
    public GameObject startButton;
    public GameObject exitButton;

    public GameObject introTextScreen;
    public bool playButtonPressed;
    public bool introSequenceDone;

    public CameraFadeAttributes cam;

    private void Start()
    {
        fadeRefference.GetComponent<CameraFadeController>().StartFade(cam);
        playButtonPressed = false;
        
    }

    public void EnterIntroSequence()
    {
        playButtonPressed = true; 
        if (playButtonPressed)
        {
            cam.cameraFadeType = CAMERA_FADE_TYPE.OUT;
            fadeRefference.GetComponent<CameraFadeController>().StartFade(cam);
            startButton.SetActive(false);
            exitButton.SetActive(false);

            StartCoroutine("EnterGameplay");
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    
    public IEnumerator EnterGameplay()
    {
        yield return new WaitForSeconds(3f);
        introTextScreen.SetActive(true);
        yield return new WaitForSeconds(3f);
    }



}
