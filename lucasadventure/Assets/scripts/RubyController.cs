using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 9.00f;
    Rigidbody2D rubyRB2D; // the player's Rigidbody
    // Start is called before the first frame update
    void Start()
       
    {

        rubyRB2D = GetComponent<Rigidbody2D>();  

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

        Debug.Log(horizontal); // see the values are you sending when pressing the keys 
    }
}
