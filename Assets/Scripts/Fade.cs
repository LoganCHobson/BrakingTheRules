using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Color color = Color.white;
    public SpriteRenderer sRend;

    void Start()
    {
        sRend = gameObject.GetComponent<SpriteRenderer>();
    }
   void OnTriggerStay2D(Collider2D other)
   {
    if(other.tag == "Player")
    {
        color.a = 0.42f;
        sRend.color = color;
    }
   }

   void OnTriggerExit2D(Collider2D other)
   {
    sRend.color = Color.white;
   }
}
