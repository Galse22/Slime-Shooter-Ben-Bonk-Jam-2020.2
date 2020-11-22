using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayScript : MonoBehaviour
{
    public GameObject Objects;
    public GameObject rocket;
    Animator anim;
    void Start()
    {
        Invoke("SetActiveFunction", 1.25f);
        Invoke("ChangeAnim", 1f);
    }

    void SetActiveFunction()
    {
        Objects.SetActive(true);
    }

    void ChangeAnim()
    {
        anim = rocket.GetComponent<Animator>();
        anim.SetBool("timePassed", true);
    }
}
