using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunScriptableObject", menuName = "BenBonkJam/GunScriptableObject", order = 0)]
public class GunScriptableObject : ScriptableObject 
{
    public float bulletDestructionTime;
    public float cooldownBtwFire;
    public GameObject bullet;
    public float bulletForce;
    public GameObject soundShoot;
}
