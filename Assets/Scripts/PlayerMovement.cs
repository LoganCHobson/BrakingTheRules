using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rb; //Getting the rigidbody
   
    public float speed = 2; //Movement Speed value

    public Animator anim;
    
    Vector2 pos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Automatically gathers the component off of the object the script is on
    }
    void Update()
    {
        anim.SetFloat("dirx", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("diry", Input.GetAxisRaw("Vertical"));
        pos = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized; //Getting the direction of the object
        
       rb.velocity = pos * speed;
        /*
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            anim.transform.Rotate(0, 180, 0);
        }
        else
        {
            anim.transform.Rotate(0, 0, 0);
        }
        */
    }// End of Update
} //End of Class

