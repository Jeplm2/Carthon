using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public controls con;

    public AudioSource drift;

    public float forwardForce = 2000f;
    public float sidewaysForce = 30f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.D) || con.moveRight == true)
        {
            transform.rotation = Quaternion.Euler(0f, 15f, 0f);
            moveRight();
        }
        if(Input.GetKey(KeyCode.A) || con.moveLeft == true)
        {
            moveLeft();
            transform.rotation = Quaternion.Euler(0f, -15f, 0f);
        }

        if(!Input.GetKey("a") && !Input.GetKey("d") && !con.moveLeft && !con.moveRight)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if(transform.rotation != Quaternion.Euler(0f, 0f, 0f))
        {
            drift.Play();
        }
        else
        {
            drift.Pause();
        }


        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    private void moveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    private void moveLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
