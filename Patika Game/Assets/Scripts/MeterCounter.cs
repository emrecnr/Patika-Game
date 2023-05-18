using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeterCounter : MonoBehaviour
{
    public Transform car; 
    public float distancePerUnit = 1f; 
    public TextMeshProUGUI meterText; 

    private float totalDistance = 0f;

    public void Counter(float distance)
    {
        float carMoveDistance = distance;


        


        totalDistance += carMoveDistance;


        meterText.text = Mathf.FloorToInt(totalDistance).ToString() + "m";
    }
}
