using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag==("Enemy"))
        {
            Debug.Log("game over");
            SceneManager.LoadScene("crowstestscene");
        }
    }
}
