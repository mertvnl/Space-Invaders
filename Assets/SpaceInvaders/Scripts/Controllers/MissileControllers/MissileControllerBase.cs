using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MissileControllerBase : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private string defaultMissileID;

    public float FireRate;
    public bool CanFire = true;

    public virtual void FireMissile()
    {
        IMissile missile = PoolingManager.Instance.InstantiatePoolObject(defaultMissileID, transform.position, transform.rotation).GetComponent<IMissile>();
        missile.Initialise(gameObject.layer);
    }
}
