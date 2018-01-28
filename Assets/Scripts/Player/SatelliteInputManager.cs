using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteInputManager : MonoBehaviour 
{
    private SatellitePlayerController satellitePlayerController;

    [Header("Queued Input Commands")]
    public List<InputCommand> inputCommands = new List<InputCommand>();

    [Header("Command Indicators")]
    public GameObject commandIndicatorPrefab;

    [Space(10)]
    public List<CommandIndicator> commandIndicators = new List<CommandIndicator>();

    private void Start()
    {
        InitializeInputManager();
    }

    private void InitializeInputManager()
    {
        satellitePlayerController = GetComponent<SatellitePlayerController>();
    }

    private void Update()
    {
        CheckNextCommand();
    }

    public void ReceiveNewCommand(InputCommand newCommand)
    {
        CreateNewIndicator(newCommand);
        inputCommands.Add(newCommand);
    }

    private void CheckNextCommand()
    {
        if (inputCommands.Count > 0)
        {
            if (CheckIfNextCommandIsReady((inputCommands[0])))
            {
                //Do the Command, Remove it from list
                PassOffInput(inputCommands[0]);

                inputCommands.Remove(inputCommands[0]);
            }
        }
    }

    private bool CheckIfNextCommandIsReady(InputCommand newCommand)
    {
        if (Time.time > newCommand.commandTime)
        {
            return true;
        }

        return false;
    }

    private void PassOffInput(InputCommand newCommand)
    {
        switch (newCommand.commandType)
        {
            case SATELLITE_COMMAND_TYPE.MOVE:
                satellitePlayerController.SetNewMovePosition(newCommand.mouseInput);
                break;

            case SATELLITE_COMMAND_TYPE.ROTATE:
                satellitePlayerController.SetMousePosition(newCommand.mouseInput);

                break;
        }
    }

    private void CreateNewIndicator(InputCommand newCommand)
    {
        GameObject newIndicator = Instantiate(commandIndicatorPrefab, satellitePlayerController.transform.position + Vector3.up, Quaternion.identity) as GameObject;
        CommandIndicator indicator = newIndicator.GetComponent<CommandIndicator>();
        indicator.SetIndicatorPoints(indicator.transform.position, newCommand.mouseInput);
    }
}
