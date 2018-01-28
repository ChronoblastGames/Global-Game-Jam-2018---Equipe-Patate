using System.Collections;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour 
{
    [Header("Player Camera Attributes")]
    public PLAYER_CAMERA_STATE playerCameraState;

    [Space(10)]
    public float cameraDragDistanceThreshold = 0.5f;

    private Vector3 cameraDragStart;
    private Vector3 cameraDragPosition;

    [Header("Camera Points")]
    public Transform[] cameraPoints;

    [Header("Camera Transition Attributes")]
    public IEnumerator currentCoroutine = null;

    [Space(10)]
    public float transitionTimeToMainScreen = 1f;
    public float transitionTimeToRadar = 1f;

    [Space(10)]
    public bool isTransitioning = false;

    private void Start()
    {
        InitializeCamera();
    }

    private void Update()
    {
        ReadInput();
    }

    private void InitializeCamera()
    {
        transform.position = cameraPoints[0].transform.position;
        transform.rotation = cameraPoints[0].transform.rotation;
    }

    private void ReadInput()
    {
        if (Input.GetMouseButtonDown(1))
        {
            cameraDragStart = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            if (!isTransitioning)
            {
                cameraDragPosition = Input.mousePosition - cameraDragStart;
                cameraDragPosition.Normalize();

                float verticalCheck = Vector3.Dot(cameraDragPosition, Vector3.up);

                if (Vector3.Distance(cameraDragStart, Input.mousePosition) > cameraDragDistanceThreshold)
                {
                    if (verticalCheck >= 0.5f)
                    {
                        switch (playerCameraState)
                        {
                            case PLAYER_CAMERA_STATE.RADAR:
                                TransitionToMainScreen();
                                break;
                        }
                    }
                    else if (verticalCheck <= -0.5f)
                    {
                        switch (playerCameraState)
                        {
                            case PLAYER_CAMERA_STATE.MAIN_SCREEN:
                                TransitionToRadar();
                                break;
                        }
                    }
                }
            }
        }
    }

    private void TransitionToMainScreen()
    {
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }

        currentCoroutine = MoveToPosition(cameraPoints[0], transitionTimeToMainScreen, true, true);

        playerCameraState = PLAYER_CAMERA_STATE.MAIN_SCREEN;

        StartCoroutine(currentCoroutine);
    }

    private void TransitionToRadar()
    {
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }

        currentCoroutine = MoveToPosition(cameraPoints[1], transitionTimeToRadar, false, false);

        playerCameraState = PLAYER_CAMERA_STATE.RADAR;

        StartCoroutine(currentCoroutine);
    }

    private IEnumerator MoveToPosition(Transform targetTransform, float transitionTime, bool isMoveLerp, bool isRotateLerp)
    {
        Vector3 currentPosition = transform.position;
        Quaternion currentRotation = transform.rotation;

        Vector3 newPosition = Vector3.zero;
        Quaternion newRotation = Quaternion.identity;

        isTransitioning = true;

        float newTransitionTime = 0f;

        while (newTransitionTime < 1f)
        {
            newTransitionTime += Time.deltaTime / transitionTime;

            if (newTransitionTime > 1)
            {
                newTransitionTime = 1f;
            }

            if (isMoveLerp)
            {
                newPosition = Vector3.Lerp(currentPosition, targetTransform.position, newTransitionTime);
            }
            else
            {
                newPosition = Vector3.Slerp(currentPosition, targetTransform.position, newTransitionTime);
            }

            if (isRotateLerp)
            {
                newRotation = Quaternion.Lerp(currentRotation, targetTransform.rotation, newTransitionTime);
            }
            else
            {
                newRotation = Quaternion.Slerp(currentRotation, targetTransform.rotation, newTransitionTime);
            }

            transform.position = newPosition;
            transform.rotation = newRotation;

            yield return new WaitForEndOfFrame();
        }

        currentCoroutine = null;

        isTransitioning = false;

        yield return null;
    }
}
