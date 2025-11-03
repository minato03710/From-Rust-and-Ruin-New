using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMSettings : MonoBehaviour
{
    private void Update()
    {
        StopCheck();
    }

    // Checks if the music is still meant to be playing
    private void StopCheck()
    {
        // The music stops in the title screen
        if(SceneManager.GetActiveScene().name == "TitleScreen")
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

}
