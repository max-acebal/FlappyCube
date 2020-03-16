using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    public float jumpPower = 50f;
    private Rigidbody rb;
    public float lrPower = 15f;
    public float maxSpeed = 10f;
    private float lrMovement;
    // Use this for initialization
    void Awake () {

        rb = GetComponent<Rigidbody>();

		
	}
	
	// Update is called once per frame
	void Update () 
    {
        lrMovement = Input.GetAxis("Horizontal");


    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jumpPower, ForceMode.VelocityChange);
        }
       
        rb.AddForce(Vector3.right * lrMovement * lrPower, ForceMode.Acceleration);

        Vector3 limitedSpeed = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

        rb.velocity = limitedSpeed;
    }
}
