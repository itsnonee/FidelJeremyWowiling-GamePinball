using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] public AudioSource bgmAudioSource;
    [SerializeField] public bool[] isMusicStop;
    private bool isStop;
    // Start is called before the first frame update

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        PlayBGM();
    }

    void Update()
    {
        if (isStop == false)
        {
            StopMusic();
        }
        else
        {
            ContinueMusic();
        }
    }

    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    void StopMusic()
    {
        for (int i = 0; i < isMusicStop.Length; i++)
        {
            if (isMusicStop[i] == true && SceneManager.GetActiveScene().buildIndex == i)
            {
                Destroy(gameObject);
            }
        }
    }

    void ContinueMusic()
    {
        for (int i = 0; i < isMusicStop.Length; i++)
        {
            if (isMusicStop[i] == true && SceneManager.GetActiveScene().buildIndex == i)
            {
                bgmAudioSource.Play();
                isStop = false;

                Debug.Log("Continue Musik");

                break;
            }
        }
    }
}
