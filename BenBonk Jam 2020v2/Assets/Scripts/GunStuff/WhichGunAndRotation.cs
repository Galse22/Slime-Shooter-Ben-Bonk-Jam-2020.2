using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichGunAndRotation : MonoBehaviour
{
    public GameObject Gun;
    private GameObject thisGO;
    public float rotationZ;

    private VariablesGunScript variablesScript;

    private float normalPosGunX;
    private float normalPosGunY;
    private float normalPosGunZ;

    private float normalRotationGunX;
    private float normalRotationGunY;
    private float normalRotationGunZ;

    private float notNormalPosGunX;
    private float notNormalPosGunY;
    private float notNormalPosGunZ;

    private float notNormalRotationGunX;
    private float notNormalRotationGunY;
    private float notNormalRotationGunZ;

    Vector3 rotationGUN;
    Vector3 positionGUN;

    void Start()
    {
        thisGO = this.gameObject;
        CurrentGun();
    }

    void Update()
    {
        RotateGun();
    }

    public void CurrentGun()
    {
        variablesScript = Gun.GetComponent<VariablesGunScript>();

        normalPosGunX = variablesScript.normalPosGunX;
        normalPosGunY = variablesScript.normalPosGunY;
        normalPosGunZ = variablesScript.normalPosGunZ;

        normalRotationGunX = variablesScript.normalRotationGunX;
        normalRotationGunY = variablesScript.normalRotationGunY;
        normalRotationGunZ = variablesScript.normalRotationGunZ;

        notNormalPosGunX = variablesScript.notNormalPosGunX;
        notNormalPosGunY = variablesScript.notNormalPosGunY;
        notNormalPosGunZ = variablesScript.notNormalPosGunZ;

        notNormalRotationGunX = variablesScript.notNormalRotationGunX;
        notNormalRotationGunY = variablesScript.notNormalRotationGunY;
        notNormalRotationGunZ = variablesScript.notNormalRotationGunZ;
    }

    void RotateGun()
    {
        rotationZ = transform.localEulerAngles.z;
        if(rotationZ <= 180)
        {
            positionGUN.Set(normalPosGunX, normalPosGunY, normalPosGunZ);
            rotationGUN.Set(normalRotationGunX, normalRotationGunY, normalRotationGunZ);
        }
        else
        {
            positionGUN.Set(notNormalPosGunX, notNormalPosGunY, notNormalPosGunZ);
            rotationGUN.Set(notNormalRotationGunX, notNormalRotationGunY, notNormalRotationGunZ);
        }
        Gun.transform.localPosition = positionGUN;
        Gun.transform.localEulerAngles = rotationGUN;
    }
}
