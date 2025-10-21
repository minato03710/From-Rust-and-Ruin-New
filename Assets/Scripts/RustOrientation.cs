using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

// This script controls the direction that Rust faces
// The script that players use to control Rust is "RustController"

public class RustOrientation : MonoBehaviour
{
    float horizontal;
    Rigidbody2D rb;
    public Transform visuals; // Visuals is used to flip Rust

    void Start()
    {
        
    }
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            visuals.transform.localEulerAngles = new Vector3(0, 180, 0);

        }

        else if (horizontal < 0)
        {
            visuals.transform.localEulerAngles = new Vector3(0, 0, 0);
        }

    }
}