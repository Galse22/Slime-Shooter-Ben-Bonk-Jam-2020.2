using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;
    float scale;
    public float minScale;
    public float differenceScalePerKill;
    public Transform transformCircle;
    public GameObject RocketDeathGO;
    public bool playingEndless;

    //public TextMeshProUGUI scoreText;
    public Text scoreText;
    public Text highScoreText;

    void Start()
    {
        highScoreText.text = "High score:" + PlayerPrefs.GetInt("HighScore");
    }

    public void EnemyKilled()
    {
        score += 50;
        if(score == 2000 || score > 2000)
        {
            if(playingEndless == false)
            {
                SceneManager.LoadScene(5);
            }
        }
        if(playingEndless == true)
        {
            if(score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
                highScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore");
            }
        }
        scoreText.text = "Score: " + score;
        Vector3 Scaler = transformCircle.localScale;
        if(Scaler.x - differenceScalePerKill >= minScale)
        {
            Scaler.x -= differenceScalePerKill;
            Scaler.y -= differenceScalePerKill;
        }
        transformCircle.localScale = Scaler;
    }
}
