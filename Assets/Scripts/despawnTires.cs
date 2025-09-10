using UnityEngine;

public class despawnTires : MonoBehaviour
{
    public CarController player;
    public NeedleController needle;
    public float missSpeed;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tire"))
        {
            Debug.Log("Missed! despawning tire.");
            Destroy(collision.gameObject);
            player.Push(missSpeed);
            needle.MoveTheNeedle(false);
        }
    }
}
