using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed;
    public float moveDistance;
    private Rigidbody2D rigidbody;
    private Vector3 currentPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
