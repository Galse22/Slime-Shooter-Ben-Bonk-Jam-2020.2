﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] public GunScriptableObject gunScriptableObject;
    private GameObject gunHolder;
    private Transform gunHolderTransform;
    private GameObject activeGun;
    private WhichGunAndRotation wgar;
    private GameObject thisGO;

    // current values
    private float localCooldownBtwFire = 0.0001f;

    // default values
    private GameObject localBulletPrefab;
    private float localBaseCooldownBtwFire;
    private float localBulletForce;

    private float localBulletDestructionTime;

    public GameObject gunPoint;

    public float varZ;

    void Start()
    {
        defineVariables();
    }

    void Update()
    {
        if(localCooldownBtwFire >= 0)
        {
            localCooldownBtwFire -= Time.deltaTime;
        }
        if(Input.GetButtonDown("Fire1") && localCooldownBtwFire <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        CinemachineShake.Instance.ShakeCamera(6f, .0125f);
        localCooldownBtwFire = localBaseCooldownBtwFire;
        GameObject bulletInstantiated = Instantiate(localBulletPrefab, gunPoint.transform.position, gunHolder.transform.rotation * Quaternion.Euler (0f, 0f, varZ));
        Rigidbody2D rb = bulletInstantiated.GetComponent<Rigidbody2D>();
        rb.AddForce(gunHolderTransform.up * localBulletForce, ForceMode2D.Impulse);
        Destroy(bulletInstantiated, localBulletDestructionTime);
    }

    void defineVariables()
    {
        thisGO = this.gameObject;
        gunHolder = GameObject.FindGameObjectWithTag("RigidBodyManager");
        wgar = gunHolder.GetComponent<WhichGunAndRotation>();
        gunHolderTransform = gunHolder.GetComponent<Transform>();
        localBulletDestructionTime = gunScriptableObject.bulletDestructionTime;
        localBulletForce = gunScriptableObject.bulletForce;
        localBulletPrefab = gunScriptableObject.bullet;
        localBaseCooldownBtwFire = gunScriptableObject.cooldownBtwFire;
    }
}
