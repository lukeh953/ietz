using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool isSpacePressed = false;
    public float movespeed = 4f;
    public float jumppower = 3f;
    public Rigidbody rb;
    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Forward");
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("backward");
            transform.Translate(Vector3.forward * -movespeed * Time.deltaTime);
        }

         void OnCollision(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }

         





        if (Input.GetKeyDown("space"))
        {
            isSpacePressed = true;
            Debug.Log("space pressed");
        }
        else
        {
            isSpacePressed = false;
        }
        if (isSpacePressed && isGrounded)
        {
            transform.Translate(Vector3.up * jumppower * Time.deltaTime);
            Debug.Log("jump");
        }

    }
}
