using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPrototype : MonoBehaviour
{
    [SerializeField]
    Text damageText; //reference to the text at the top-left of the screen.



    public void updateDamage() {
        //Use this function to update the damage text on the top left of the screen.
        //For example if your character runs into the cube this script is attached to
        //update 'damageText' to display "Damage : 5%" on the screen.

        //Hint: Look into using tags and colliders
    }
}
