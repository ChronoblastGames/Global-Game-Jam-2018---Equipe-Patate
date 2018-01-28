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

    public void SetIndictor(Vector3 start, Vector3 end)
    {
        commandStartPoint = start;
        commandEndPoint = end;

        lineRenderer.SetPosition(0, commandStartPoint);
        lineRenderer.SetPosition(1, commandEndPoint);
    }

    public void DestroyIndicator()
    {
        Destroy(gameObject, indicatorTime);
    }
}
