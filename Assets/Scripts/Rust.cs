using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 initialFall; // The player's starting position -- Where Rust wakes up
    [SerializeField] float rustPower; // The strength in which Rust can perform actions
    [SerializeField] float rustSpeed; // How fast Rusts can move
    Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialFall = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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

    void CutSceneTrigger() // When Rust hits a cutscene trigger point
    {

    }
}
