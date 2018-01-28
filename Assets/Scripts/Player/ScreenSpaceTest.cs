using System.Collections;
using UnityEngine;

public class ScreenSpaceTest : MonoBehaviour 
{
    public Camera mainCamera;
    public Camera targetCamera;

    public LayerMask screenMask;
    public LayerMask backgroundMask;

    private Ray newRay;
    private RaycastHit newRayHit;

    public Vector3 mouseScreenPosition;
    public Vector3 texCoordHitVec;

    private void Update()
    {
        GetMousePosition();
    }

    private void GetMousePosition()
    {
        if (Input.GetMouseButtonDown((0)))
        {
            newRay = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(newRay, out newRayHit, screenMask))
            {
                texCoordHitVec = newRayHit.textureCoord;

                Ray secondRay = targetCamera.ViewportPointToRay(texCoordHitVec);

                if (Physics.Raycast(secondRay, out newRayHit, backgroundMask))
                {
                    Debug.Log("Please work hit :: " + newRayHit.point);
                }
            }
        }
    }

}