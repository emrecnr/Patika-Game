using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondCamera;
    public GameObject playerPref;

    private void Start()
    {
        // Baþlangýçta ikinci kamerayý devre dýþý býrak
        secondCamera.enabled = false;
    }

    private void Update()
    {
        // E tuþuna bastýðýnda kameralarý deðiþtir
        if (Input.GetKeyDown(KeyCode.E))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondCamera.enabled = !secondCamera.enabled;
        }
        secondCamera.transform.rotation = playerPref.transform.rotation;    
    }
}
