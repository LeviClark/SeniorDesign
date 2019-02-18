using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody thisBody;
    void Start()
    {
        thisBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        Vector3 jump = new Vector3(moveHorizontal, 155.0f, 0.0f);
        if (Input.GetKeyDown(KeyCode.W))
        {
            thisBody.AddForce(jump);
        }
        else
        {
            thisBody.AddForce(movement * speed);
        }
        
    }
}
