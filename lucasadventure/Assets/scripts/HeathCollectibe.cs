﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathCollectibe : MonoBehaviour
{

    void OnTriggerenter2D(Collider2D other)
    {
        Debug.Log("object thatcentered the trigger: " + other);
            RubyController controller = other.GetComponent<RubyController>();
        // get the player controllerf from the other thing collied with the trigger


        if (controller != null)// of thecontroller retrived is no empty
        {


            // ! the exclamatiom is a negation value
            if (controller.currentHealth < controller.maxHealth )
         
            controller.ChangeHealth(1);
            // call the health fuction and add 1 to the health of the player
            

            Destroy(gameObject); // Destroys allthe game object and this script too!  

        }
    }
}
