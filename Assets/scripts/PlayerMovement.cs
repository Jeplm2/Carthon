using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public endTrigger end;
    float r;
    public controls con;

    public AudioSource drift;
    public AudioSource med;
    public AudioSource low;

    public float forwardForce = 2000f;
    public float sidewaysForce = 30f;

    void FixedUpdate()
    {
        if (end.CompleteLevel == false)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        else
        {
            drift.Pause();
            drift.Play();
            med.Pause();
            low.Play();
        }
        
        if(Input.GetKey(KeyCode.D) || con.moveRight == true)
        {
            moveRight();
            drift.Play();
        }
        if(Input.GetKey(KeyCode.A) || con.moveLeft == true)
        {
            moveLeft();
            drift.Play();
        }

        if(!Input.GetKey("a") && !Input.GetKey("d") && !con.moveLeft && !con.moveRight)
        {
            smoothRotate(0f);
            drift.Pause();
        }


        if(rb.position.y < -1f)
        {
            forwardForce = 0f;
            sidewaysForce = 0f;
            drift.Play();
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    private void moveRight()
    {
        smoothRotate(15f);
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    private void moveLeft()
    {
        smoothRotate(-15f);
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    private void smoothRotate(float target)
    {
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target, ref r, 0.1f);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
