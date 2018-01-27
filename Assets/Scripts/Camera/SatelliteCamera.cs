using System.Collections;
using UnityEngine;

public class SatelliteCamera : MonoBehaviour 
{
    [Header("Camera Attributes")]
    public Transform targetObject;

    [Header("Camera Movement Attributes")]
    public CameraMovementValues cameraMovementValues;

    private Vector3 cameraMoveSmoothVelocity;

    private void LateUpdate()
    {
        ManageCameraMovement();
    }

    private void ManageCameraMovement()
    {
        Vector3 cameraTargetPosition = targetObject.transform.position;
        cameraTargetPosition.y = cameraMovementValues.cameraRestingHeight;

        Vector3 cameraCurrentMovePosition = Vector3.SmoothDamp(transform.position, cameraTargetPosition, ref cameraMoveSmoothVelocity, cameraMovementValues.cameraMoveSmoothTime);

        transform.position = cameraCurrentMovePosition;
    }
}

[System.Serializable]
public class CameraMovementValues
{
    [Header("Camera Movement Attributes")]
    public float cameraMoveSmoothTime = 0.1f;

    [Space(10)]
    public float cameraRestingHeight;
}

