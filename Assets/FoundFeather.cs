using UnityEngine;

public class FoundFeather : MonoBehaviour
{

    Animator useAnimator;

    void Start()
    {
        useAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        useAnimator.SetBool("isTouching", true);
    }

}