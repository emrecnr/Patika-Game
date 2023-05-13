using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] cars;
    public Transform[] carsSpawnPoint;

    public float spawnInterval = 5f;
    private Vector3 spawnRotation = new Vector3(0, 180, 0);
    private WaitForSeconds waitTime;

    public bool gameOn = true;

    private void Start()
    {
        waitTime = new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnCar());
    }
    IEnumerator SpawnCar() 
    {
        while(gameOn) 
        {
            int carIndex = Random.Range(0, cars.Length);
            int spawnIndex = Random.Range(0, carsSpawnPoint.Length);

            Vector3 spawnPosition = carsSpawnPoint[spawnIndex].position;

            Instantiate(cars[carIndex], spawnPosition,Quaternion.identity);
            yield return waitTime;

        }
      
    }
   
}
