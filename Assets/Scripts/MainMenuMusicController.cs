using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusicController : MonoBehaviour
{
    [SerializeField] private AudioSource bgmAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        bgmAudioSource.Play();
    }
}
