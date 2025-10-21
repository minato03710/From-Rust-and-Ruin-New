using UnityEngine;
using UnityEngine.SceneManagement;

public class CliffMove : MonoBehaviour
{

    Animator cliffAnimator;

    void Start()
    {
        cliffAnimator = GetComponent<Animator>();

        if(SceneManager.GetActiveScene().name == "Scene 1 (After)") // This animation only plays once the player has interacted with Burrowbeak
        {
            cliffAnimator.SetBool("canMove", true);
        }
    }
}
