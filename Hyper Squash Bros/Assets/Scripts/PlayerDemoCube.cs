using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;

public class PlayerDemoCube : PlayerDemoCubeBehavior
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!networkObject.IsOwner)
        {
            transform.position = networkObject.Position;

            transform.rotation = networkObject.Rotation;

            return;
        }
        Vector3 translation = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

        // Scale the speed to normalize for processors
        translation *= speed * Time.deltaTime;

        // Move the object by the given translation
        transform.position += translation;

        // Just a random rotation on all axis
        transform.Rotate(new Vector3(speed, speed, speed) * 0.25f);

        // Since we are the owner, tell the network the updated position
        networkObject.Position = transform.position;

        // Since we are the owner, tell the network the updated rotation
        networkObject.Rotation = transform.rotation;

    }

}
