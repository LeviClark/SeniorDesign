using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Unity;
using BeardedManStudios.Forge.Networking.Lobby;

public class CharacterDriver : CharacterDriverBehavior
{
    public float walkSpeed = 3f;
    public float gravity = -2;
    public float jumpHeight = .5f;
    public float forceDamageModifier = 1.0f; //Percentage base damage/force modifier
    public float health = 100.0f;
    public Vector3 velocity;//The actual velocity vector that the character is currently moving along
    private uint playerNumber;
    private int playerLives;

    private CharacterController controller;
    private Camera cam;
    private float speedY;
    private bool canDoubleJump = true;
    private bool recoil = false;//Used to "ragdoll" punches
    private Animator myAnimator;

    public Vector3 spawn = new Vector3(0.0f, 12.5f);

    protected override void NetworkStart()
    {
        base.NetworkStart();
        controller = GetComponent<CharacterController>();
        myAnimator = GetComponent<Animator>();
        playerNumber = LobbyService.Instance.MyMockPlayer.NetworkId;
        switch (playerNumber)
        {
            case 0:
                spawn = new Vector3(-11.0f, 12.5f);
                break;
            case 1:
                spawn = new Vector3(-5.0f, 12.5f);
                break;
            case 2:
                spawn = new Vector3(5.0f, 12.5f);
                break;
            case 3:
                spawn = new Vector3(11.0f, 12.5f);
                break;
        }
    }

    public override void TakeDamage(RpcArgs args)
    {
        //RPCs aren't usually run on unity's main thread for performance, since we're using it
        //to directly modify a GameObject we want to use the main thread
        MainThreadManager.Run(() =>
        {
            //Code for knockbacks
            //this.forceDamageModifier = forceDamageModifier + .1f;
            //this.StartCoroutine("ResetRecoil", forceDamageModifier);
            //this.recoil = true;

            health -= 10;
        });
    }

    private IEnumerator ResetRecoil(float waitTime) {
        while (true) {
            yield return new WaitForSeconds(waitTime * 2);
            this.recoil = false;
            yield return null;
        }
    }
    void Start()
    {
        playerLives = 3;
        switch (playerNumber)
        {
            case 0:
                spawn = new Vector3(-11.0f, 12.5f);
                break;
            case 1:
                spawn = new Vector3(-5.0f, 12.5f);
                break;
            case 2:
                spawn = new Vector3(5.0f, 12.5f);
                break;
            case 3:
                spawn = new Vector3(11.0f, 12.5f);
                break;
        }

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
            
            myAnimator.SetBool("isIdle", networkObject.isIdle);
            myAnimator.SetBool("isRunning", networkObject.isRunning);
            myAnimator.SetBool("isAttackingRight", networkObject.isAttackingRight);
            myAnimator.SetBool("isAttackingLeft", networkObject.isAttackingLeft);
            transform.position = networkObject.position;
            transform.rotation = networkObject.rotation;

            //Since this isn't our character, exit this loop and do not check for input
            return;
        }

        //Reset falling speed if on the ground
        if (controller.isGrounded)
        {
            canDoubleJump = true;
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

        if(Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.D) )
        {
            myAnimator.SetBool("isRunning", true);
            myAnimator.SetBool("isIdle", false);
        }
        else{
            myAnimator.SetBool("isRunning", false);
            myAnimator.SetBool("isIdle", true);
            
        }

        if (direction > 0 && !recoil)
        {
           // myAnimator.CrossFade("Run", 0.1f);
            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
            velocity = transform.forward * Time.deltaTime * 5 * walkSpeed;
        }
        else if (direction < 0)
        {
            //myAnimator.CrossFade("Armature|Run", 0.1f);
            gameObject.transform.eulerAngles = new Vector3(0, -90, 0);
           velocity = transform.forward * Time.deltaTime * 5 * walkSpeed;
        }
        else {
            velocity = Vector3.zero;
        }

        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.A))
        {
            myAnimator.SetBool("isAttackingLeft", true);
        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.D))
        {
            myAnimator.SetBool("isAttackingRight", true);
        }
        else if (Input.GetMouseButtonDown(0)){
            myAnimator.SetBool("isAttackingLeft", true);
        }
        else
        {
            myAnimator.SetBool("isAttackingLeft", false);
            myAnimator.SetBool("isAttackingRight", false);

        }
        

        MeleeAttack();
        if (transform.position.y <= -16.0f || transform.position.x >= 40.0f || transform.position.x <= -40.0f)
        {
            transform.position = spawn;
            networkObject.lives--;
            playerLives--;
            networkObject.health = 100;
        }


        //Send the updated positions and rotations over the network

        networkObject.isAttackingRight = myAnimator.GetBool("isAttackingRight");
        networkObject.isAttackingLeft = myAnimator.GetBool("isAttackingLeft");
        networkObject.isRunning = myAnimator.GetBool("isRunning");
        networkObject.isIdle = myAnimator.GetBool("isIdle");
        networkObject.position = transform.position;
        networkObject.rotation = transform.rotation;

    }
    
    void Jump()
    {
        if (controller.isGrounded || canDoubleJump == true)
        {
            
            float jumpVelocity = Mathf.Sqrt(-.2f * gravity * jumpHeight);
            speedY = jumpVelocity;

            if(!controller.isGrounded && canDoubleJump) {
                jumpVelocity = Mathf.Sqrt(-.2f * gravity * jumpHeight/2);
                speedY = jumpVelocity;
                canDoubleJump = false;
            }
        }
    }

    void MeleeAttack() {
        if (Input.GetMouseButtonDown(0)) {
            
            
            Vector3 forward = transform.TransformDirection((Vector3.forward)) * 3;
            Debug.DrawRay(transform.position, forward, Color.blue);//Used for visual debugging
            RaycastHit hit;

            if (Physics.Raycast(transform.position, forward, out hit)) {
                Debug.Log("Hit " + hit.collider.gameObject.tag + "!");
                if (hit.collider.gameObject.tag == "Player") {
                    Debug.Log("HIT A PLAYER");
                    //Grab reference to the player's RPC call and call it on all clients
                    hit.collider.gameObject.GetComponent<CharacterDriver>().networkObject.SendRpc(RPC_TAKE_DAMAGE, Receivers.All);

                    //Used for knockback
                    //Vector3 dir = hit.collider.gameObject.transform.position - gameObject.transform.position;
                    //dir.Normalize();
                    //hit.collider.gameObject.GetComponent<CharacterDriver>().velocity = dir * hit.collider.gameObject.GetComponent<CharacterDriver>().forceDamageModifier * 5;
                }
            }
            
        }
    }

    //For use when taking hits/knockbacks
    public void SetVelocity(Vector3 dir, float force) {
        velocity = dir;
        velocity = velocity * force;
    }
    
}