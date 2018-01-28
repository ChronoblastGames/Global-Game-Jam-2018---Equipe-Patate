using System.Collections;
using UnityEngine;

public class SatellitePlayerController : MonoBehaviour 
{
    private BackgroundMover backgroundMover;

    private GameOver gameOverManager;

    [Header("Player Attributes")]
    private Vector3 mouseWorldPosition = Vector3.zero;

    [Header("Player Movement Attributes")]
    public PlayerMovementValues playerMovementValues;

    private Vector3 playerMoveSmoothVelocity;

    private Vector3 targetMovePosition = Vector3.zero;

    [Header("Player Rotation Attributes")]
    public PlayerRotationValues playerRotationValues;

    private float playerRotateSmoothVelocity;

    private Vector3 targetRotationPosition = Vector3.zero;

    private void Start()
    {
        InitializePlayer();
    }

    private void Update()
    {
        ManageMovement();
        ManageRotation();
    }

    private void InitializePlayer()
    {
        backgroundMover = GameObject.FindGameObjectWithTag("Background").GetComponent<BackgroundMover>();

        gameOverManager = GameObject.FindGameObjectWithTag("GameOverManager").GetComponent<GameOver>();
    }

    public void SetMousePosition(Vector3 newMousePosition)
    {
        mouseWorldPosition = newMousePosition;
    }

    private void ManageMovement()
    {
        if (targetMovePosition != Vector3.zero)
        {
            Vector3 currentMovePosition = Vector3.SmoothDamp(transform.position, targetMovePosition, ref playerMoveSmoothVelocity, playerMovementValues.playerMoveSmoothTime);

            transform.position = currentMovePosition;
        }
    }

    private void ManageRotation()
    {
        Vector3 lookDirection = (targetRotationPosition - transform.position).normalized;

        float targetRotation = Mathf.Atan2(lookDirection.x, lookDirection.z) * Mathf.Rad2Deg;

        Vector3 newPlayerRotation = new Vector3(transform.rotation.eulerAngles.x, 1 * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref playerRotateSmoothVelocity, playerRotationValues.playerRotateSmoothTime));

        transform.rotation = Quaternion.Euler(newPlayerRotation);
    }

    public void SetNewMovePosition(Vector3 targetMousePosition)
    {
        Vector3 targetPosition = (targetMousePosition - transform.position).normalized;

        targetMovePosition = targetMousePosition;

        backgroundMover.SetNewTargetDirection(targetPosition);
    }

    public void SetNewRotationPosition(Vector3 newTargetRotationPosition)
    {
        targetRotationPosition = newTargetRotationPosition;
    }

    public void PlayerDeath()
    {
        gameOverManager.YouDied();
    }

    private void PlayerReset()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
    }
}

[System.Serializable]
public class PlayerMovementValues
{
    [Header("Player Movement Attributes")]
    public float playerMoveSmoothTime = 0.1f;
}

[System.Serializable]
public class PlayerRotationValues
{
    [Header("Player Rotation Attributes")]
    public float playerRotateSmoothTime = 0.1f;
}
