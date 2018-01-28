using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour {


    [Header("Obstacles")]

    public GameObject playerCharacter;
    public GameObject[] obstacleList;

    GameObject spawnedObstacle;
    [Header("Obstacle Spawn Settings")]
    public float spawnDistanceMax;
    public float spawnDistanceMin;


    // Use this for initialization
    void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            SpawnObject();
        }
	}

    void SpawnObject() {
        spawnedObstacle = Instantiate(obstacleList[Random.Range(0, (obstacleList.Length))]);
        SetSpawnLocation(spawnedObstacle);
        //spawnedObstacle.GetComponent<Asteroid>().obstacleTrajectoryDirection
    }

    void SetSpawnLocation(GameObject objectToPosition) {
        Vector3 spawnLocation = new Vector3();

        spawnLocation.x = ResolveRandomMath() * (Mathf.Clamp((Mathf.Abs(Random.insideUnitSphere.x) * Random.Range(spawnDistanceMin, spawnDistanceMax)), spawnDistanceMin, spawnDistanceMax));
        spawnLocation.y = 1;
        spawnLocation.z = ResolveRandomMath()* (Mathf.Clamp((Mathf.Abs(Random.insideUnitSphere.z) * Random.Range(spawnDistanceMin, spawnDistanceMax)), spawnDistanceMin, spawnDistanceMax));
        Debug.Log(spawnLocation.x +" " + spawnLocation.y + " " + spawnLocation.z);
        objectToPosition.transform.position = spawnLocation;
        //Set Approach Vector
        objectToPosition.GetComponent<Asteroid>().obstacleTrajectoryDirection = FindApproachVector(spawnLocation, playerCharacter.transform.position);
        objectToPosition.GetComponent<Asteroid>().canObstacleMove = true;
    }
    float ResolveRandomMath() {

        if (Random.insideUnitSphere.x > 0)
        {
            return -1f;
        }
        else {
            return 1f;
        }

    }
    Vector3 FindApproachVector(Vector3 objSpawnPosition, Vector3 playerCurrentPosition) {
        Vector3 approachVector = new Vector3();
        approachVector.x =  (playerCurrentPosition.x * Random.Range(-5f,5f)) - objSpawnPosition.x;
        approachVector.y = 0 ;
        approachVector.z = (playerCurrentPosition.z * Random.Range(-5f,5f)) - objSpawnPosition.z;

        approachVector.Normalize();
        return approachVector;

    }
    
}

