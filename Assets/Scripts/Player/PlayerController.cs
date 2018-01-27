using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    [Header("Player Movement Attributes")]
    public PlayerMovementValues playerMovementValues;

    private Vector3 mouseWorldPosition = Vector3.zero;

    public void SetMousePosition(Vector3 newMousePosition)
    {
        mouseWorldPosition = newMousePosition;
    }

    public void SetNewMovePosition()
    {
        
    }
}

[System.Serializable]
public class PlayerMovementValues
{
    [Header("Player Movement Attributes")]
    public float playerMoveToPositionSpeed = 10f;
}
