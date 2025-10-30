using UnityEngine;

// This script starts the final cutscene once the goal of freeing the feather is reached

public class FoundSecondFeather : MonoBehaviour
{
    Animator useAnimator;
    Animator burrowAnimator;
    Animator cameraAnimator;

    void Start()
    {
        useAnimator = GetComponent<Animator>();
    }

    public void ControlRust() // Rust responds to the goal being reached and starts acting in the cutscene
    {
        GameObject searchRust = GameObject.Find("Rust_Puppet_Rig_Coloured"); // Finds Rust
        searchRust.GetComponent<RustController>().enabled = false; // Stops Rust's script that allows for player control in order to freeze movement
        searchRust.GetComponent<RustVisuals>().enabled = false;
        useAnimator = searchRust.GetComponentInChildren<Animator>();
        useAnimator.Play("rust_found_feather");
    }

    public void ControlBurrowbeak() // Burrowbeak responds to the goal being reached and starts acting in the cutscene
    {
        GameObject searchBurrow = GameObject.Find("Burrowbeak Flying"); // Finds Burrowbeak
        burrowAnimator = searchBurrow.GetComponentInChildren<Animator>();
        burrowAnimator.Play("BurrowbeakFlying");
    }

    public void ControlCamera() // Cutscene camera follows Burrowbeak
    {
        GameObject searchCamera = GameObject.Find("Main Camera"); // Finds Burrowbeak
        cameraAnimator = searchCamera.GetComponent<Animator>();
        cameraAnimator.Play("CameraEndCutscene");
    }

    public void FinalCutscene() // All things to be triggered for the final cutscene
    {
        ControlRust();
        ControlBurrowbeak();
        ControlCamera();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        useAnimator.SetBool("isTouching", true); // When the player has found the feather, the animation plays
        FinalCutscene(); // Starts final cutscene
    }

}