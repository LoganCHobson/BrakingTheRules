using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomaly : MonoBehaviour
{
    Renderer m_paint;
    Rigidbody2D body; 
    public int anomalySetter;

    public ToDoList TDL;

    public string name;
    public bool completed;
    private bool inRange;

    Material material;

    bool isDissolving = false;
    float fade = 1f;
    public float fadeSpeed = 1;

    void Awake()
    {
        TDL.objects.Add(gameObject);
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {

        
        if (inRange == true)
        {
            if (anomalySetter == 1)
            {
                Switch();
            }
            if (anomalySetter == 2)
            {
                Floating();
            }
            if (anomalySetter == 3)
            {
                Disappear();
            }
            if (anomalySetter == 4)
            {
                Size();
            }
        }

        //Code for dissolving shader
        if (isDissolving)
        {
            fade -= Time.deltaTime * fadeSpeed;

            if (fade <= 0f)
            {
               
                completed = true;
                fade = 0f;
                TDL.objects.Remove(gameObject);
                Destroy(gameObject, 1);
            }

            material.SetFloat("_Fade", fade);

        }

    
    void Switch()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           m_paint = GetComponent<Renderer>();
            m_paint.material.color = Color.green;
                completed = true;
                TDL.objects.Remove(gameObject);

            }
    }

    void Floating()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body = GetComponent<Rigidbody2D>();
            body.isKinematic = false;
                
                completed = true;
                TDL.objects.Remove(gameObject);
            }
    }

    void Disappear()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDissolving = true;
               
            }
        }
    }
    
    void Size()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // anime.SetTrigger("triggerGrowth");
        }
    }
        
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            inRange = true;
        }
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }

    }

}



   

