using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController Instance { get; set; }
    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject sfxAudioSource;
    [SerializeField] TextMeshProUGUI title;

    public bool isGameOver = false;
    private bool isGamePaused = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("PinBall");
        ResumeGame();
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        ResumeGame();
    }
    public void GameOver()
    {
        isGameOver = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    private void ToggleMenu()
    {
        if(isGameOver)
        {
            return;
        }

        GameObject menuGame = TriggerGameOver.Instance.panelMenu;
        isGamePaused = !isGamePaused; // Toggle the state of game pause

        if (isGamePaused)
        {
            title.text = "Pause Game";
            menuGame.SetActive(true); // Activate the menu game
            PauseGame();
            PauseMusic();
        }
        else
        {
            menuGame.SetActive(false); // Deactivate the menu game
            ResumeGame();
            ResumeMusic();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Set time scale to 0 to pause the game
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Set time scale to 1 to resume the game
    }

    private void PauseMusic()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    private void ResumeMusic()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
