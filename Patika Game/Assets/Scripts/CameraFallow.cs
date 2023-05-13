using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    Vector3 camOffset = new Vector3(0f, 5f, -11f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        

        transform.position = player.transform.position+camOffset;
        
    }
}
