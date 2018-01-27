using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenManager : MonoBehaviour
{
    private AsyncOperation asyncLoader;

    [Header("Loading Attributes")]
    public int sceneToLoad;

    public float loadDelay;

    private bool isReadyToGo = false;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    private void Update()
    {
        CheckForInput();     
    }

    private IEnumerator LoadScene ()
    {
        asyncLoader = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);
        asyncLoader.allowSceneActivation = false;

        while (!asyncLoader.isDone)
        {
            yield return new WaitForSeconds(loadDelay);        

            isReadyToGo = true;

            yield return null;
        }
    }

    private void CheckForInput()
    {
        if (isReadyToGo)
        {
            if (Input.anyKeyDown)
            {
                asyncLoader.allowSceneActivation = true;
            }
        }
    }  
}
