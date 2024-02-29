using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] public AudioSource bgmAudioSource;
    [SerializeField] private GameObject sfxBumperAudioSource;
    [SerializeField] private GameObject sfxSwitchAudioSource;
    // Start is called before the first frame update

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
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxBumperAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchAudioSource, spawnPosition, Quaternion.identity);
    }
}
