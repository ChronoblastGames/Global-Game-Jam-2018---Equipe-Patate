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
        Vector3[] linePoints = new Vector3[2] { startPoint, endPoint };

        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.SetPositions(linePoints);
    }

    public void DestroyIndicator()
    {
        Destroy(gameObject, indicatorTime);
    }
}
