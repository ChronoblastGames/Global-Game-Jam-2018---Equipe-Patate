using System.Collections;
using UnityEngine;

public class InputCommand 
{
    [Header("Command Values")]
    public SATELLITE_COMMAND_TYPE commandType;

    [Space(10)]
    public Vector3 mouseInput = Vector3.zero;

    [Space(10)]
    public float commandTime = 0f;
}
