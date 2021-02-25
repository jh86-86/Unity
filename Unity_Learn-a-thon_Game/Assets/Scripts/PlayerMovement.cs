using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // this is a reference to the rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 100f;
    public bool onGround = true;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate() // use FixedUpdate as unity likes it better + will make it smoother
    {
        // add a forwardForce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //we do this so the update speed isnt tied to framerate 

        if (Input.GetKey("d")) // this is bad code! look around if you want to improve 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("space") && onGround == true)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            onGround = false;
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Ground")
        {
            Debug.Log("hello");
            onGround = true;
        }
    }
}

