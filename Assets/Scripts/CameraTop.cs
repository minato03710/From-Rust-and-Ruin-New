using UnityEngine;

public class CameraTop : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ControlCameraTop();
    }

    public void ControlCameraTop()
    {
        GameObject searchCamera = GameObject.Find("Main Camera"); // Finds the Main Camera
        searchCamera.GetComponent<Animator>().Play("CameraTop");
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.enabled = false;
    }

}
