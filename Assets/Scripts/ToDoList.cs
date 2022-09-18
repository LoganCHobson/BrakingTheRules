using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ToDoList : MonoBehaviour
{
    public int win;
    public Anomaly AN;
    //public TMP_Text text;
    public List<GameObject> objects;

    public List<TMP_Text> lables  = new List<TMP_Text>();
    
    public GameObject checkthing1, checkthing2, checkthing3, checkthing4, checkthing5, checkthing6, checkthing7;
    
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
        if(objects.Count == 0)
        {
            SceneManager.LoadScene("win");
        }
       
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
        if (objects[4].GetComponent<Anomaly>().completed == true)
        {
            checkthing5.SetActive(true);
            
        }
        if (objects[5].GetComponent<Anomaly>().completed == true)
        {
            checkthing6.SetActive(true);
            
        }
        if (objects[6].GetComponent<Anomaly>().completed == true)
        {
            checkthing7.SetActive(true);
            
        }

    }
}
