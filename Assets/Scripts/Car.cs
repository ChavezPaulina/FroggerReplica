
using UnityEngine;

public class Car : MonoBehaviour
{
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    public Rigidbody2D rb;
     float speed = 1f;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed); 
    }

    //Speed of game from slider
    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
