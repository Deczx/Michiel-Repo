using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{

    public float horizontalMovementSpeed;
    public float horizontalMaxSpeed;
    public float verticalMovementSpeed;
    public float verticalMaxSpeed;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        horizontalMovementSpeed = 4f;
        horizontalMaxSpeed = 4f;

        verticalMovementSpeed = 4f;
        verticalMaxSpeed = 4f;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal and vertical axis
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Set movement to according key pressed
        if (Input.GetKey(KeyCode.D)) rb.velocity += (Vector2.right * h) * horizontalMovementSpeed;
        if (Input.GetKey(KeyCode.A)) rb.velocity -= (Vector2.left * h) * horizontalMovementSpeed;
        if (Input.GetKey(KeyCode.W)) rb.velocity += (Vector2.up * v) * verticalMovementSpeed;
        if (Input.GetKey(KeyCode.S)) rb.velocity -= (Vector2.down * v) * verticalMovementSpeed;


        // Set max movement speeds
        if (rb.velocity.x >= 4f) rb.velocity = new Vector2(horizontalMaxSpeed, rb.velocity.y);
        if (rb.velocity.x <= -4f) rb.velocity = new Vector2(-horizontalMaxSpeed, rb.velocity.y);
        if (rb.velocity.y >= 4f) rb.velocity = new Vector2(rb.velocity.x, verticalMaxSpeed);
        if (rb.velocity.y <= -4f) rb.velocity = new Vector2(rb.velocity.x, -verticalMaxSpeed);

    }

    // handle collisions
    void OnCollisionEnter2D(Collision2D other)
    {

    }


}
