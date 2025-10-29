using UnityEngine;

public class MetBurrowbeak : MonoBehaviour
{

    Animator visualsAnimator;
    Animator cameraAnimator;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MoveCamera();
        RustResponse();
    }

    public void RustResponse() // Rust responds to Burrowbeak in the cutscene
    {
        GameObject searchRust = GameObject.Find("Rust_Puppet_Rig_Coloured"); // Finds Rust
        searchRust.GetComponent<RustController>().enabled = false; // Stops Rust's script that allows for player control in order to freeze movement
        searchRust.GetComponent<RustVisuals>().enabled = false;
        visualsAnimator = searchRust.GetComponentInChildren<Animator>();
        visualsAnimator.Play("rust_meets_burrowbeak");
    }

    public void MoveCamera()
    {
        GameObject searchCamera = GameObject.Find("Camera");
        cameraAnimator = searchCamera.GetComponent<Animator>();
        cameraAnimator.Play("CameraBurrowbeak");
    }
}
