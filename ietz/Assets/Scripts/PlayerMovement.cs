using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movespeed = 10f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("Forward");
            rb.AddForce(0, 0, movespeed, ForceMode.Impulse);
        }
        
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("backward");
            rb.AddForce(0, 0, -movespeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("Forward");
            rb.AddForce(0, 0, movespeed, ForceMode.Impulse);
        }



    }
}
