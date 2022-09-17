using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; //Getting the rigidbody
   
    public float speed = 2; //Movement Speed value

    Vector2 pos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Automatically gathers the component off of the object the script is on
    }
    void Update()
    {
        pos = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical")).normalized;; //Getting the direction of the object
        
       rb.velocity = pos * speed;
    }// End of Update
} //End of Class

