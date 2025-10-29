using UnityEngine;

public class LayerFade : MonoBehaviour
{

    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("playerVisited", true);
        ControlCameraUp();
    }

    public void ControlCameraUp()
    {
        GameObject searchCamera = GameObject.Find("Main Camera"); // Finds the Main Camera
        searchCamera.GetComponent<Animator>().Play("CameraMiddle");
    }

}