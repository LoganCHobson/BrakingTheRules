using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public string Name;
    public void playgame ()
    {
        SceneManager.LoadScene(Name);

    }

    public void quit()
    {
        Application.Quit();
    }


}
