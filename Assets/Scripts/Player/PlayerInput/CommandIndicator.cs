using System.Collections;
using UnityEngine;

public class CommandIndicator : MonoBehaviour 
{
    private LineRenderer lineRenderer;

    [Header("Indicator Attributes")]
    public Vector3 commandStartPoint;
    public Vector3 commandEndPoint;

    [Space(10)]
    public float indicatorTime;

    private void Start()
    {
        InitializeIndicator();
    }

    private void InitializeIndicator()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    public void SetIndicatorPoints(Vector3 startPoint, Vector3 endPoint)
    {
        lineRenderer.positionCount = 2;

        commandStartPoint = Vector3.zero;
        commandEndPoint = transform.InverseTransformPoint(endPoint + Vector3.up); 

        lineRenderer.SetPosition(0, commandStartPoint);
        lineRenderer.SetPosition(1, endPoint);
    }

    public void DestroyIndicator()
    {
        Destroy(gameObject, indicatorTime);
    }
}
