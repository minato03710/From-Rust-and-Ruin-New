using UnityEngine;

public class RustController : MonoBehaviour
{
    Vector3 initialFall; // The player's starting position -- Where Rust wakes up
    [SerializeField] float rustPower; // The strength in which Rust can perform actions
    [SerializeField] float rustSpeed; // How fast Rusts can move
    Rigidbody2D rb;

    void Start()
    {
        initialFall = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) // Space key to jump
        {
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * rustSpeed);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector2.right * rustSpeed);
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * rustPower);
    }

    void StartGame() // Player is told that game has started
    {
        transform.position = initialFall;
        rb.gravityScale = 1;
    }
}
}