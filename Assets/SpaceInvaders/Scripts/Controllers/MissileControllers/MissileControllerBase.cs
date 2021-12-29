using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MissileControllerBase : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    public float FireRate;
    public bool CanFire = true;

    public GameObject defaultMissile;


    public virtual void FireMissile()
    {
        IMissile missile = Instantiate(defaultMissile, firePoint.position, firePoint.rotation).GetComponent<IMissile>();
        missile.Initialise();
    }
}
