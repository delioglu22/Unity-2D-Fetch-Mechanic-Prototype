using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with Obstacle Detected");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger with Goal Detected");
    }
}
