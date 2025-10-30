using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleCanvas : MonoBehaviour
{

// When the Start Game button is pressed
public void OnStartPressed()
    {
        SceneManager.LoadScene("Scene 1"); // Loads the starting scene
    }

// When the Exit button is pressed
public void OnExitPressed()
    {
        Application.Quit(); // Closes the game
        Debug.Log("Exit game");
    }

}