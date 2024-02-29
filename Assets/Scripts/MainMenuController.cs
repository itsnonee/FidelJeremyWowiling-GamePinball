using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("PinBall");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
