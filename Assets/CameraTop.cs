using UnityEngine;

public class CameraTop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ControlCameraTop();
    }

    public void ControlCameraTop()
    {
        GameObject searchCamera = GameObject.Find("Main Camera"); // Finds the Main Camera
        searchCamera.GetComponent<Animator>().Play("CameraTop");
    }

}
