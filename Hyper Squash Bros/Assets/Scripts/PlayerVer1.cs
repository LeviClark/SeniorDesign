using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Lobby;
using UnityEngine.UI;

public class PlayerVer1 : PlayerVer1Behavior
{
    // Start is called before the first frame update
    public float speed = 3.0f;
    public float walkSpeed = 3.0f;
    public float gravity = -3;
    public float jumpHeight = 1.15f;
    public bool canDoubleJump = true;
	public int playerLives = 3;
	public Text PlayerLives;

    private Camera cam;

    private CharacterController controller;

    private Vector3 velocity;
    private float speedY;
    public Vector3 spawn = new Vector3(0.0f, 12.5f);

    
    protected override void NetworkStart()
    {
        base.NetworkStart();
        controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        if (LobbyService.Instance.IsServer)
        {
            networkObject.charType = LobbyService.Instance.MyMockPlayer.AvatarID;
        }

        if (!networkObject.IsOwner)
        {
            switch (networkObject.charType)
            {
                case 0:
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 1:
                    gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
                case 2:
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case 3:
                    gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                    break;
                case 4:
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
			PlayerLives.text = "Lives: " + playerLives;

            return;
        }
        
        networkObject.charType = LobbyService.Instance.MyMockPlayer.AvatarID;
        switch (networkObject.charType)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
        }
        uint playerNumber = LobbyService.Instance.MyMockPlayer.NetworkId;
        switch (playerNumber)
        {
            case 1:
                spawn = new Vector3(-8.0f, 12.5f);
                break;
            case 2:
                spawn = new Vector3(-4.0f, 12.5f);
                break;
            case 3:
                spawn = new Vector3(4.0f, 12.5f);
                break;
            case 4:
                spawn = new Vector3(8.0f, 12.5f);
                break;
        }
        networkObject.lives = 3;
        networkObject.damage = 0;
        transform.position = spawn;
		playerLives = networkObject.lives;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (!networkObject.IsOwner)
        {
            
            transform.position = networkObject.position;
            transform.rotation = networkObject.rotation;
            return;
        }
        switch (networkObject.charType)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
        }



        //Reset falling speed if on the ground
        if (controller.isGrounded)
        {
            canDoubleJump = true;
            speedY = 0;
        }

        //Recieve inputs
        float direction = Input.GetAxis("Horizontal");
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
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
        else
        {
            velocity = Vector3.zero;
        }


        //Send the updated positions and rotations over the network
        if (transform.position.y <= -16.0f || transform.position.x >= 40.0f || transform.position.x <= -40.0f)
        {
            transform.position = spawn;
            networkObject.lives--;
			playerLives--;
            networkObject.damage = 0;
        }
        
        networkObject.position = transform.position;
        networkObject.rotation = transform.rotation;
        networkObject.isGrounded = controller.isGrounded;


    }
    public override void Attack(RpcArgs args)
    {
        throw new System.NotImplementedException();
    }
    
    void Jump()
    {
        if (controller.isGrounded || canDoubleJump == true)
        {

            float jumpVelocity = Mathf.Sqrt(-.2f * gravity * jumpHeight);
            speedY = jumpVelocity;

            if (!controller.isGrounded && canDoubleJump)
            {
                jumpVelocity = Mathf.Sqrt(-.2f * gravity * jumpHeight / 2);
                speedY = jumpVelocity;
                canDoubleJump = false;
            }
        }
    }
}
