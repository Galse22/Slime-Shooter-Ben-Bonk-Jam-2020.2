using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkEnemy : MonoBehaviour
{
    public float speedEnemy;
    public float timeWait = 0.75f;
    public float timeBeforeWait = 1f;
    private Transform _rocketPosition;
    bool canWalk = true;
    Animator anim;
    void Start()
    {
        _rocketPosition = GameObject.FindGameObjectWithTag("Rocket").transform;
        anim = GetComponent<Animator>();
        Invoke("StopWalking", 1f);
    }

    void Update()
    {
        if(canWalk)
        {
            transform.position = Vector2.MoveTowards (transform.position, _rocketPosition.position, speedEnemy * Time.deltaTime);
        }
    }

    void StopWalking()
    {
        canWalk = false;
        anim.SetBool("Walking", false);
        Invoke("StartWalking", timeWait);
    }

    void StartWalking()
    {
        canWalk = true;
        anim.SetBool("Walking", true);
        Invoke("StopWalking", timeBeforeWait);
    }
}
