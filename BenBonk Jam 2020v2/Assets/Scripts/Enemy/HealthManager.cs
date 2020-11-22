using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    GameObject scoreManagerGO;
    ScoreManager scoreManager;
    public int health;
    public Material baseMaterial;
    public Material whiteMat;
    Renderer rend;
    void Start()
    {
        scoreManagerGO = GameObject.FindGameObjectWithTag("Manager");
        scoreManager = scoreManagerGO.GetComponent<ScoreManager>();
        rend = GetComponent<Renderer>();
    }

    public void TakeDamage()
    {
        CinemachineShake.Instance.ShakeCamera(2f, .04f);
        health -= 1;
        if(health == 0 || 0 > health)
        {
            scoreManager.EnemyKilled();
            Destroy(this.gameObject);
        }
        rend.material = whiteMat;
        Invoke("ResetColor", 0.1f);
    }

    void ResetColor()
    {
        rend.material = baseMaterial;
    }
}
