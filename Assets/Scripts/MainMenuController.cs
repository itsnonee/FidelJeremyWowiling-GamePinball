using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("PinBall");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("tes");
    }
}
