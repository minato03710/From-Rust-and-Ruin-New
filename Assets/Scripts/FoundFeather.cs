using UnityEngine;

// This script starts the final cutscene once the goal of freeing the feather is reached

public class FoundFeather : MonoBehaviour
{

    Animator useAnimator;

    void Start()
    {
        useAnimator = GetComponent<Animator>();
    }

    public void ControlRust() // Rust responds to the goal being reached and starts acting in the cutscene
    {
        GameObject searchRust = GameObject.Find("Rust_Puppet_Rig_Coloured"); // Finds Rust
        searchRust.GetComponent<RustController>().enabled = false; // Stops Rust's script that allows for player control in order to freeze movement
        searchRust.GetComponent<RustOrientation>().enabled = false;
        searchRust.GetComponent<Animator>().Play("rust_found_feather");
        
    }

    public void FinalCutscene() // All things to be triggered for the final cutscene
    {
        ControlRust();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        useAnimator.SetBool("isTouching", true); // When the player has found the feather, the animation plays
        FinalCutscene(); // Starts final cutscene
    }

}