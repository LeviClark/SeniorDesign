using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;

public class CharacterDriver : CharacterDriverBehavior
{
    public float walkSpeed = 50f;
    public float gravity = -2;
    public float jumpHeight = 2f;

    private CharacterController controller;
    private Camera cam;
    private Vector3 velocity;//The actual velocity vector that the character is currently moving along
    private float speedY;

    protected override void NetworkStart()
    {
        base.NetworkStart();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: TEMP
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }


        //If this isn't our character just update its values client-side
        if (!networkObject.IsOwner)
        {
            //Assign position and rotation of this object to the values sent over the network
            transform.position = networkObject.position;
            transform.rotation = networkObject.rotation;

            //Since this isn't our character, exit this loop and do not check for input
            return;
        }

        //Reset falling speed if on the ground
        if (controller.isGrounded)
        {
            speedY = 0;
        }

        //Recieve inputs
        float direction = Input.GetAxis("Horizontal");
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) {
            direction = 0;
        }
        speedY += Time.deltaTime * gravity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        velocity = velocity + (Vector3.up * speedY);
        controller.Move(velocity);
        //Apply gathered input to character position/rotation
        //transform.Translate(Vector3.forward * Time.deltaTime * moveForward);
        //controller.Move(velocity);
        if (direction > 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, -90, 0);
            velocity = -(transform.forward * Time.deltaTime * 5 * walkSpeed);
        }
        else if (direction < 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
           velocity = -(transform.forward * Time.deltaTime * 5 * walkSpeed);
        }
        else {
            velocity = Vector3.zero;
        }


        //Send the updated positions and rotations over the network
        networkObject.position = transform.position;
        networkObject.rotation = transform.rotation;

    }

    void Jump()
    {
        if (controller.isGrounded)
        {
            float jumpVelocity = Mathf.Sqrt(-.2f * gravity * jumpHeight);
            speedY = jumpVelocity;
        }
    }
    
}