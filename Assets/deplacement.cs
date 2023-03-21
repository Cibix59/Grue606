using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    public float force = 400.0f;
    public float torque = 800.0f;
    public ArticulationBody articulationBody;

    private void Start() { }

    private void FixedUpdate()
    {
        //rotation
        float rotateInput = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateInput = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateInput = 1;
        }

        Vector3 torqueDirection = transform.TransformDirection(0, 1, 0) * rotateInput * torque;
        articulationBody.AddTorque(torqueDirection);

        //avancer
        float moveInput = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveInput = -1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveInput = 1;
        }

        Vector3 forceDirection = transform.TransformDirection(0, 0, 1) * moveInput * force;
        articulationBody.AddForce(forceDirection);
    }
}
