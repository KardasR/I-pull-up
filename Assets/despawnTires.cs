using UnityEngine;

public class despawnTires : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tire"))
        {
            Debug.Log("Missed! despawning tire.");
            Destroy(collision.gameObject);
        }
    }
}
