using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    //timer values
    public float speed = 9999.00f;
    Rigidbody2D rubyRB2D; // the player's Rigidbody
    public int maxHealth = 5;
     public int currentHealth;


    public float timeInvincible;
    bool isInvincible;
    float Invincibletimer;

    // Start is called before the first frame update
    void Start()
    {
        rubyRB2D = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth; // the current health is the max health aviable to the player

        currentHealth = 1; //
    }

    // Update is called once per frame
    void Update()   
    {

        float horizontal = Input.GetAxis("Horizontal"); // get the horizontal input
        float vertical = Input.GetAxis("Vertical"); // get the vertical input 

        Vector2 position = transform.position; // makes a vector based on current position 

        position.x = position.x + speed * horizontal * Time.deltaTime; // the position is qual to the same position but a little bit bigger
        position.y = position.y + speed * vertical * Time.deltaTime; // called each second instead ofof each frame

        transform.position = position; // saves this position to the current one
        rubyRB2D.MovePosition(position);

        if (isInvincible)
        {
             Invincibletimer -= Time.deltaTime; // the timer ended
            if (Invincibletimer < 0)
            {
                isInvincible = false;                                                                                                                                                                                                                                                                                                                 
            }
                
        }

               
    }



   public void ChangeHealth(int amout)
    {
        if (amout < 0) // as is inferior to 0, it means damage
        {
            return;
            isInvincibleTImer = timeInvincible; // resets the timer to the public value

        }



        currentHealth = Mathf.Clamp(currentHealth + amout, 0, maxHealth);
        // limits the number between 0 and the max health
        Debug.Log(currentHealth + "/" + maxHealth);
        


   
    }

}