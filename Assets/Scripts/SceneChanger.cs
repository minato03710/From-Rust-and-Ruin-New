using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    [SerializeField] string changeScene;

    public void SwitchScene()
    {
        SceneManager.LoadScene(changeScene);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SwitchScene();
    }

}
