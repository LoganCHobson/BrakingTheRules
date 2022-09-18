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
    
    public GameObject checkthing1, checkthing2, checkthing3, checkthing4;
    
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
        if(objects[0].GetComponent<Anomaly>().completed == true)
        {
            checkthing1.SetActive(true);
        }
        if(objects[1].GetComponent<Anomaly>().completed == true)
        {
            checkthing2.SetActive(true);
        }
        if(objects[2].GetComponent<Anomaly>().completed == true)
        {
            checkthing3.SetActive(true);
        }
        if(objects[3].GetComponent<Anomaly>().completed == true)
        {
            checkthing4.SetActive(true);
        }
        
    }
}
