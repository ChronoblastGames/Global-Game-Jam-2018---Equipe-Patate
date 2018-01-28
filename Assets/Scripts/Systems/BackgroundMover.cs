using System.Collections;
using UnityEngine;

public class BackgroundMover : MonoBehaviour 
{
    [Header("Target Attributes")]
    public Transform targetTransform;

    private void Update()
    {
        SetBackgroundToPlayerPosition();   
    }

    private void SetBackgroundToPlayerPosition()
    {
        transform.position = targetTransform.position;
    }
}
