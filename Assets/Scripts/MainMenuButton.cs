using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{

    public void OnMainMenuPressed()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}
