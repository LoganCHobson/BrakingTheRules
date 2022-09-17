using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Renderer m_paint;


    public int anomaly;
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
            m_paint = GetComponent<Renderer>();
            
        }
    }
    
    
    void OnTriggerStays2D(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(anomaly == 1)
            {
                Switch();
            }
            
        }
       
    }
}
