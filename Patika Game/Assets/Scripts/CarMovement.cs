using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    Cars cars;
    public float moveSpeed = 25f;
    private float turnSpeed = 35f;


    private float horizontalInput;
    private float forwardInput;

    public GameObject skybox;

    private float distance = 1;
    public bool isGrounded=true;


    private void Awake()
    {
        Renderer rendererr = GetComponent<Renderer>();
    }

    void Update()
    {
        Move();
        Skybox();

        if (!isGrounded)
        {
            FindObjectOfType<GameOver>().GameOvr(); 
        }
    }

    private void Move()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveSpeed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
        if (forwardInput > 0)
        {

            FindObjectOfType<MeterCounter>().Counter(distance * Time.deltaTime);
        }


    }
    void Skybox()
    {
        // Skybox'un hareketini arabayla iliþkilendirerek güncelleme
        float skyboxMove = moveSpeed * Time.deltaTime;
        skybox.transform.position = transform.position;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Road"))
        {
            isGrounded = false;
        }
    }



    
}
