using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] cars;
    public Transform[] carsSpawnPoint;

    private float spawnInterval=5;
    private Vector3 spawnRotation = new Vector3(0, 180, 0);
    private WaitForSeconds waitTime;

    private float intervalDecreaseAmount = 0.5f; // spawn aralýðýnýn azalma miktari
    public float elapsedTime;//gecen süre
    public bool gameOn = true;



    private void Start()
    {
        
        waitTime = new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnCar());

        elapsedTime = 0f;
    }

    private void Update()
    {
        SpawnDecrease();
    }
    private void SpawnDecrease()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 15)
        {
            spawnInterval -= intervalDecreaseAmount;
            elapsedTime = 0f;
        }
    }
    IEnumerator SpawnCar()
    {
        while (gameOn)
        {
            int carIndex = Random.Range(0, cars.Length);
            int spawnIndex = Random.Range(0, carsSpawnPoint.Length);

            Vector3 spawnPosition = carsSpawnPoint[spawnIndex].position;

            Instantiate(cars[carIndex], spawnPosition, Quaternion.identity);


            yield return new WaitForSeconds(spawnInterval);

        }

    }

}
