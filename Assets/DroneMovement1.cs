using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement1 : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, 2000 * Time.deltaTime);

        //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight)){
        if(Input.GetKey("d")){
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft)){
        if(Input.GetKey("a")){
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

        //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp)){
        if(Input.GetKey("w")){
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown)){
        if(Input.GetKey("s")){
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
    }
}