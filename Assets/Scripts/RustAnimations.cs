using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class RustAnimations : MonoBehaviour
{
    float horizontal;
    public Animator anim;
    Rigidbody2D rb;
    public Transform visuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

        if(horizontal != 0)
        {
            anim.SetBool("isMoving", true);   // isMoving is set to true when no horizontal movement is occuring
        }

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
