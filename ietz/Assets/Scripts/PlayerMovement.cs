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
    Rigidbody rigidbody;
    
        void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.CompareTag("Ground"))
        {
        isSpacePressed = true;
        Debug.Log("terrain collide");
        }
        }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
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



    if (isGrounded = true);
        {

        if (Input.GetKeyDown("space"))
        {
            isSpacePressed = true;
            Debug.Log("space pressed");
            rigidbody.AddForce(transform.up * jumppower);
        }
        }


    }
}
