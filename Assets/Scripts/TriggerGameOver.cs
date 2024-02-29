using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerGameOver : MonoBehaviour
{
    public static TriggerGameOver Instance {get; set;}
    [SerializeField] public GameObject panelMenu;
    [SerializeField] GameObject panelScore;
    [SerializeField] public TextMeshProUGUI title;
    [SerializeField] Collider bola;

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
        panelScore.SetActive(true);
        panelMenu.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            title.text = "Game Over";
            panelScore.SetActive(false);
            panelMenu.SetActive(true);
            MenuController.Instance.GameOver();
            MenuController.Instance.PauseGame();
            MenuController.Instance.StopMusic();
            MenuController.Instance.PlaySFX(other.transform.position);
        }
    }
}
