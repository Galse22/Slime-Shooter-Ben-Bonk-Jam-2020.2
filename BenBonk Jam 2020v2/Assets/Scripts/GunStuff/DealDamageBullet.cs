using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageBullet : MonoBehaviour
{
    private HealthManager healthManager;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            healthManager = col.gameObject.GetComponent<HealthManager>();
            healthManager.TakeDamage();
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "Rocket")
        {
            Destroy(this.gameObject);
        }
    }
}
