using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    Cars cars;
    private float moveSpeed = 25f;
    private float turnSpeed = 35f;


    private float horizontalInput;
    private float forwardInput;

    

    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveSpeed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

    }
}
