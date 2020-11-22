using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRocket : MonoBehaviour
{
    GameObject rocketDeathGO;
    GameObject Manager;
    ScoreManager scoreManager;
    public GameObject explosionSound;
    bool hasAttacked;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            if(hasAttacked == false)
            {
                Instantiate(explosionSound, this.gameObject.transform.position, Quaternion.identity);
                CinemachineShake.Instance.ShakeCamera(30f, .1f);
                Manager = GameObject.FindWithTag("Manager");
                scoreManager = Manager.GetComponent<ScoreManager>();
                rocketDeathGO = scoreManager.RocketDeathGO;
                rocketDeathGO.SetActive(true);
                Invoke("SetTimeScale", 0.12f);
                hasAttacked = true;
            }
        }
    }

    void SetTimeScale()
    {
        Time.timeScale = 0f;
    }
}
