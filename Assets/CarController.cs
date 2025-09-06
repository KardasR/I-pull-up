using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed;

    private Vector3 positionToMoveTo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionToMoveTo = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, positionToMoveTo, moveSpeed * Time.deltaTime);
    }

    public void Push(float force)
    {
        positionToMoveTo += Vector3.right * force;
    }
}
