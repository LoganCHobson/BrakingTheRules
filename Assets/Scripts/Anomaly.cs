using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomaly : MonoBehaviour
{
    Renderer m_paint;
    Rigidbody body; 
    public int anomalySetter;

    public ToDoList TDL;

    public string name;
    public bool completed;

    void Awake()
    {
        TDL.objects.Add(gameObject);
    }

    void update()
    {
        if(completed == true)
        {
            gameObject.SetActive(false);
        }
    }

    
    void Switch()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           m_paint = GetComponent<Renderer>();
            m_paint.material.color = Color.red;
        }
    }

    void Floating()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body = GetComponent<Rigidbody>();
            body.isKinematic = false;
            
        }
    }

    void Disappear()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
    }
        }
        
    
    
    void OnTriggerStays2D(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(anomalySetter == 1)
            {
                Switch();
            }
            if(anomalySetter == 2)
            {
                Floating();
            }
            if(anomalySetter == 3)
            {
                Disappear();
            }
        }
       
    }
}