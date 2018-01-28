using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteInputController : MonoBehaviour 
{
    private SatellitePlayerController playerController;
    private SatelliteInputManager inputManager;
    private TransmissionManager transmissionManager;

    [Header("Player Input Attributes")]
    public Camera mainCamera;
    public Camera targetCamera;

    public Vector2 playerMouseInput;

    [Space(10)]
    public Vector3 playerMousePosition;

    [Space(10)]
    public float mouseHitPointVerticalAdjust = 1f;

    [Space(10)]
    public LayerMask screenMask;
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

        inputManager = GetComponent<SatelliteInputManager>();

        transmissionManager = GameObject.FindGameObjectWithTag(("TransmissionManager")).GetComponent<TransmissionManager>();
    }

    private void GetInput()
    {
        playerMouseInput = Input.mousePosition;

        GetPlayerMousePosition();

        if (Input.GetMouseButtonDown(0))
        {
            SendNewMovePosition();
        }

        SendNewRotationPosition();
    }

    private void GetPlayerMousePosition()
    {
        playerMousePosition = ReturnPlayerMousePositionInWorld();

        playerController.SetMousePosition(playerMousePosition);
    }
 
    private void SendNewMovePosition()
    {
        InputCommand newCommand = CreateNewCommand(SATELLITE_COMMAND_TYPE.MOVE, transmissionManager.ReturnTotalTransmissionTime(), playerMousePosition);

        inputManager.ReceiveNewCommand(newCommand);
    }

    private void SendNewRotationPosition()
    {
        playerController.SetNewRotationPosition(playerMousePosition);
    }

    private Vector3 ReturnPlayerMousePositionInWorld()
    {
        Vector3 newPlayerMousePosition = Vector3.zero;
        Vector3 texCoordHitVec = Vector3.zero;

        Ray newRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit newRayHit;

        if (Physics.Raycast(newRay, out newRayHit, screenMask))
        {
            texCoordHitVec = newRayHit.textureCoord;

            Ray secondRay = targetCamera.ViewportPointToRay(texCoordHitVec);

            if (Physics.Raycast(secondRay, out newRayHit, backgroundMask))
            {
                newPlayerMousePosition = newRayHit.point;
                newPlayerMousePosition.y = mouseHitPointVerticalAdjust;
            }
        }

        return newPlayerMousePosition;
    }

    private InputCommand CreateNewCommand(SATELLITE_COMMAND_TYPE commandType, float commandTime, Vector3 commandMousePosition)
    {
        InputCommand newCommand = new InputCommand();

        newCommand.commandType = commandType;
        newCommand.commandTime = commandTime;
        newCommand.mouseInput = commandMousePosition;

        return newCommand;
    }
}
