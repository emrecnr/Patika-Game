using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public Vector3 camOffset;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        

        transform.position = player.transform.position+camOffset;
        
        
        
    }
    
}
