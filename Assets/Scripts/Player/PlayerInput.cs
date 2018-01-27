using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour 
{
    [Header("Player Input Attributess")]
    public Vector3 playerMouseInput;

    [Space(10)]
    public float mouseHitPointVerticalAdjust = 1f;

    [Space(10)]
    public LayerMask backgroundMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown((0)))
        {
            GetPlayerMousePosition();
        }
    }

    private void GetPlayerMousePosition()
    {
        playerMouseInput = ReturnPlayerMousePositionInWorld();
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
