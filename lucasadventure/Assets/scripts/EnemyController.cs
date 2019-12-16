using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC : MonoBehaviour
  
    

   
{
    public float speed; // speed of the enemy
    Rigidbody rb2D;

    public bool isVertical; // if it's not, it will walk horizontali
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody>(); // get hte enemy's Rigibody
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = rb2D.position;


        if (isVertical)
        {
            position.y = position.y + Time.deltaTime * speed;
        }
        position.x = position.x + Time.deltaTime * speed;
        // sum the positio x with the speed and the time 

        rb2D.MovePosition(position);
        // apply the previus sum position to the enemy's rigibody
        
    }
}
