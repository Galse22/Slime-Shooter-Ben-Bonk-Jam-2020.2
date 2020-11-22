using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float score;
    float scale;
    public float minScale;
    public float differenceScalePerKill;
    public Transform transformCircle;

    //public TextMeshProUGUI scoreText;
    public Text scoreText;

    public void EnemyKilled()
    {
        score += 50;
        if(score == 2000 || score > 2000)
        {
            //SceneManager.LoadScene(2);
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
