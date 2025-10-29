using UnityEngine;
using UnityEngine.SceneManagement;


public class RustSceneChecker : MonoBehaviour
{

    private RustController controlsReference;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controlsReference = GetComponent<RustController>();


        // These settings only apply when Rust in Scene 2
        if(SceneManager.GetActiveScene().name == "Scene 2")
        {
            // Makes sure that the reference is valid
            if(controlsReference != null){

                // Grabs the rustPower variable from the RustController script
                controlsReference.rustPower = 100;

                // Grabs the rustSpeed variable from the RustController script
                controlsReference.rustSpeed = 0.25f;

                // Sets Rust's walk animation for this scene to WaryWalk
                // Placeholder
            }
        }

        // These settings apply when Rust is in any other scene
        else
        {
            // Makes sure that the reference is valid
            if(controlsReference != null){

                // Grabs the rustPower variable from the RustController script
                controlsReference.rustPower = 150;

                // Grabs the rustSpeed variable from the RustController script
                controlsReference.rustSpeed = 0.3f;
            }
        }
    }
}