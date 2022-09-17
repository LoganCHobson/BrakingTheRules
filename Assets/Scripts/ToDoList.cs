using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToDoList : MonoBehaviour
{
    //public TMP_Text text;
    public List<GameObject> objects = new List<GameObject>();

    public List<TMP_Text> lables = new List<TMP_Text>();
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        foreach(TMP_Text lables in lables)
        {
             
        }
    }
}
