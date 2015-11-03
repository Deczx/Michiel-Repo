using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{

    public float horizontalMovementSpeed;
    public float verticalMovementSpeed;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal and vertical axis
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(h * horizontalMovementSpeed, v * verticalMovementSpeed);
    }

    // handle collisions
    void OnCollisionEnter2D(Collision2D other)
    {

    }


}
