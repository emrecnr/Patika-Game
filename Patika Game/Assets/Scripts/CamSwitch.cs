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
        // Ba�lang��ta ikinci kameray� devre d��� b�rak
        secondCamera.enabled = false;
    }

    private void Update()
    {
        // E tu�una bast���nda kameralar� de�i�tir
        if (Input.GetKeyDown(KeyCode.E))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondCamera.enabled = !secondCamera.enabled;
        }
        secondCamera.transform.rotation = playerPref.transform.rotation;    
    }
}
