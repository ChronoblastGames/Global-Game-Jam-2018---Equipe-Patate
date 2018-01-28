using System.Collections;
using UnityEngine;

public class TransmissionManager : MonoBehaviour 
{
    [Header("Transmission Attributes")]
    public float currentTransmissionTime = 0f;

    [Space(10)]
    public float transmissionFractional = 100f;

    [Header("Player Attributes")]
    public Transform targetPlayer;

    [Space(10)]
    public float playerDistanceFromOrigin = 0f;

    private void Start()
    {
        InitializeTransmissionManager();
    }

    private void Update()
    {
        UpdateCurrentTransmissionTime();
        UpdatePlayerDistance();
    }

    private void InitializeTransmissionManager()
    {
        if (targetPlayer == null)
        {
            targetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
    }

    private void UpdateCurrentTransmissionTime()
    {
        currentTransmissionTime = ReturnCurrentTransmissionTime();
    }

    private void UpdatePlayerDistance()
    {
        playerDistanceFromOrigin = Vector3.Distance(Vector3.zero + Vector3.up, targetPlayer.transform.position);
        playerDistanceFromOrigin *= 10f;
    }

    public float ReturnTotalTransmissionTime()
    {
        return currentTransmissionTime + Time.time;   
    }

    private float ReturnCurrentTransmissionTime()
    {
        float newTransmissionTime = 0f;

        newTransmissionTime = playerDistanceFromOrigin / transmissionFractional;

        return newTransmissionTime;
    }
}
