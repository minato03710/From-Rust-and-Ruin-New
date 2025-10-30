using UnityEngine;

public class CameraDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ControlCameraUp();
    }

    public void ControlCameraUp()
    {
        GameObject searchCamera = GameObject.Find("Main Camera"); // Finds the Main Camera
        searchCamera.GetComponent<Animator>().Play("CameraIdle");
    }

}
