using UnityEngine;

public class RustController : MonoBehaviour
{

    Rigidbody2D rb;
    public float rustPower; // Jump power
    public float rustSpeed; // Movement speed
    public string activeAnimation; // Determines which animation will play
    public int jumpCount; // Sets the number of times that Rust can jump
    public bool touchingGround; // Checks if Rust is touching the ground


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 2;
    }

    // Update is called once per frame
    public void Update()
    {
        // Space key triggers jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(jumpCount > 0)
            {
                Jump();
            }
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * rustSpeed);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * rustSpeed);
        }
    }

    // Jump
    void Jump()
    {
        jumpCount -= 1; // Subtracts number of jumps remaining by 1
        rb.AddForce(Vector2.up * rustPower);
    }

    // Checks if the player has collided with a platform
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            jumpCount = 2; // Resets the number of times that the player can jump
            touchingGround = true;
        }
    }

    // Checks if the player has left a platform
    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            touchingGround = false;
        }
    }

}