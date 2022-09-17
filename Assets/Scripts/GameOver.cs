using UnityEngine;

public class GameOver : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag==("Enemy"))
        {
            Debug.Log("game over");

            Destroy(gameObject);
        }
    }
}
