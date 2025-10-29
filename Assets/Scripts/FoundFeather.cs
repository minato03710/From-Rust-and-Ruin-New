using UnityEngine;

// This script starts the final cutscene once the goal of freeing the feather is reached

public class FoundFeather : MonoBehaviour
{
    Animator useAnimator;

    void Start()
    {
        useAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        useAnimator.SetBool("isTouching", true); // When the player has found the feather, the animation plays
    }

}