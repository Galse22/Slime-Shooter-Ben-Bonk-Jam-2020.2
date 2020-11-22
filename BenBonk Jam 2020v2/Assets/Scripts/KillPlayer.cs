using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject deathGO;
    public GameObject hitSound;
    public PlayerMovement playerMov;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(hitSound, this.gameObject.transform.position, Quaternion.identity);
            CinemachineShake.Instance.ShakeCamera(30f, .1f);
            deathGO.SetActive(true);
            Animator anim = GetComponent<Animator>();
            anim.SetBool("isDead", true);
            playerMov.canMove = false;
            Invoke("SetTimeScale", 0.5f);
        }
    }

    void SetTimeScale()
    {
        Time.timeScale = 0f;
    }
}
