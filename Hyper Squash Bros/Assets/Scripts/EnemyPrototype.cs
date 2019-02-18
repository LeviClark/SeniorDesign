using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPrototype : MonoBehaviour
{
    [SerializeField]
    Text damageText; //reference to the text at the top-left of the screen.
    int health;
    private Rigidbody thisBody;
    void Start()
    {
        thisBody = GetComponent<Rigidbody>();
        health = 0;
        damageText.text = "Damage : " + health + "%";
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            health = health + 5;
            updateDamage();
        }
    }

    public void updateDamage() {
        //Use this function to update the damage text on the top left of the screen.
        //For example if your character runs into the cube this script is attached to
        //update 'damageText' to display "Damage : 5%" on the screen.

        //Hint: Look into using tags and colliders

        damageText.text = "Damage : " + health + "%";
        
    }
}
