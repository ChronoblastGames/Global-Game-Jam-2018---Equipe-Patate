using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteInputController : MonoBehaviour 
{
    private SatellitePlayerController playerController;

    [Header("Player Input Attributess")]
    public Vector2 playerMouseInput;

    [Space(10)]
    public Vector3 playerMousePosition;

    [Space(10)]
    public float mouseHitPointVerticalAdjust = 1f;

    [Space(10)]
    public LayerMask backgroundMask;

    private void Start()
    {
        InitializeInput();
    }

    private void Update()
    {
        GetInput();
    }

    private void InitializeInput()
    {
        playerController = GetComponent<SatellitePlayerController>();
    }

    private void GetInput()
    {
        playerMouseInput = Input.mousePosition;

        GetPlayerMousePosition();

        if (Input.GetMouseButtonDown(0))
        {
            SendNewMovePosition();
        }
    }

    private void GetPlayerMousePosition()
    {
        playerMousePosition = ReturnPlayerMousePositionInWorld();

        playerController.SetMousePosition(playerMousePosition);
    }

    private void SendNewMovePosition()
    {
        playerController.SetNewMovePosition(playerMousePosition);
    }

    private Vector3 ReturnPlayerMousePositionInWorld()
    {
        Vector3 newPlayerMousePosition = Vector3.zero;

        Ray newMousePointRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit newMouseRayHit;

        if (Physics.Raycast(newMousePointRay, out newMouseRayHit, backgroundMask))
        {
            newPlayerMousePosition = newMouseRayHit.point;
            newPlayerMousePosition.Set(newPlayerMousePosition.x, mouseHitPointVerticalAdjust, newPlayerMousePosition.z);
        }

        return newPlayerMousePosition;
    }
}
