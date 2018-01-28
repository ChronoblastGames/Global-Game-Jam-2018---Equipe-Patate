using System.Collections;
using UnityEngine;

public class Asteroid : MonoBehaviour 
{
    [Header("Obstacle Movement Attributes")]
    public ObstacleMovementValues obstacleMovementValues;

    [Space(10)]
    public Vector3 obstacleTrajectoryDirection = Vector3.zero;

    [Space(10)]
    private int obstacleSpinDirection = 0;

    [Space(10)]
    public bool canObstacleMove = false;

    [Header("Obstacle Damage Attributes")]
    public ObstacleDamageValues obstacleDamageValues;

    private void Start()
    {
        InitializeObstacle();
    }

    private void InitializeObstacle()
    {
        float spinDirectionValue = Random.value;

        if (spinDirectionValue > 0.5f)
        {
            obstacleSpinDirection = 1;
        }
        else
        {
            obstacleSpinDirection = -1;
        }
    }

    private void Update()
    {
        MoveObstacle();
        RotateObstacle();
    }

    private void MoveObstacle()
    {
        if (canObstacleMove)
        {
            Vector3 newMovePosition = (obstacleTrajectoryDirection * obstacleMovementValues.obstacleMoveSpeed) * Time.deltaTime;

            transform.position += newMovePosition;
        }
    }

    private void RotateObstacle()
    {
        if (canObstacleMove)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + (obstacleMovementValues.obstacleSpinSpeed * obstacleSpinDirection) * Time.deltaTime, transform.eulerAngles.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(("Player")))
        {
            Debug.Log("Hit Player");
        }
    }
}

[System.Serializable]
public class ObstacleMovementValues
{
    [Header("Obstacle Movement Attributes")]
    public float obstacleMoveSpeed = 10f;

    [Space(10)]
    public float obstacleSpinSpeed = 10f;
}

[System.Serializable]
public class ObstacleDamageValues
{
    [Header("Obstacle Damage Attributes")]
    public float obstacleDamage;
}
