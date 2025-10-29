using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

// This script controls visual aspects of Rust such as their animation and orientation

public class RustVisuals : MonoBehaviour
{
    float movementOrientation;
    Rigidbody2D rb;
    public Transform visuals; // Visuals is used to flip Rust
    public Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movementOrientation = Input.GetAxisRaw("Horizontal");

        // Flips Rust depending on horizontal direction
        if(movementOrientation != 0)
        {
            Vector3 scale = visuals.localScale;
            scale.x = (movementOrientation < 0) ? Mathf.Abs(scale.x) : -Mathf.Abs(scale.y); // Ensures that positive and negative values don't get messed up
            visuals.localScale = scale;
        }

        // Sets Rust's speed in the animator to determine if they are currently moving
        animator.SetFloat("currentSpeed", Mathf.Abs(movementOrientation));

    }

}