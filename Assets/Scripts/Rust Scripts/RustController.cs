using UnityEngine;

public class RustController : MonoBehaviour
{

    Rigidbody2D rb;
    public float rustPower; // Jump power
    public float rustSpeed; // Movement speed
    public int jumpCount; // Max jumps before landing
    public bool touchingGround; // Checks if touching ground
    public Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 2; // Can jump twice before landing
    }

    // Update is called once per frame
    public void Update()
    {
        // Space key triggers jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(jumpCount > 0) // Checks if there are jumps left
            {
                Jump();
            }
        }

        // Pressing A moves Rust to the left
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * rustSpeed);
        }

        // Pressing D moves Rust to the right
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
        animator.SetBool("onGround", false);
    }

    // Checks if the player has collided with a platform
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            jumpCount = 2; // Resets the number of jumps remaining
            touchingGround = true;
            animator.SetBool("onGround", true);
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