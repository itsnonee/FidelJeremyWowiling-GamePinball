using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreTextEndGame;

    void Update()
    {
        scoreText.text = ScoreManager.Instance.score.ToString();
        scoreTextEndGame.text = ScoreManager.Instance.score.ToString();
    }
}
