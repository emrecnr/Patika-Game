using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cars:MonoBehaviour
{
    public Camera cam;
    private Renderer rendererr;
    public float moveSpeed;

    private void Awake()
    {
        cam = Camera.main;
         rendererr = GetComponent<Renderer>();
    }
    private void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        transform.Translate(Vector3.forward * moveSpeed*Time.deltaTime);
        if (!rendererr.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
