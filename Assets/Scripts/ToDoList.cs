using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToDoList : MonoBehaviour
{
    public Anomaly AN;
    //public TMP_Text text;
    public List<GameObject> objects;

    public List<TMP_Text> lables  = new List<TMP_Text>();

    
    // Start is called before the first frame update

    void Awake()
    {
        
    }

    void Start()
    {
        for(int i = 0; i < lables.Count; i++)
        {
            if (objects.Count <= i)
                break;
            
            lables[i].text = objects[i].GetComponent<Anomaly>().name;
        }       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
