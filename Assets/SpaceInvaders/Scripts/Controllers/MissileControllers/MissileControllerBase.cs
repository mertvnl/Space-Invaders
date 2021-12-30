using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class MissileControllerBase : MonoBehaviour
{
    [SerializeField] private MissileTypeData missileTypeData;
    [SerializeField] private Missile currentMissile;
    [SerializeField] private Transform firePoint;

    public float FireRate;
    public bool CanFire = true;

    public virtual void Awake()
    {
        UpdateCurrentMissile(currentMissile.MissileType);
    }

    public virtual void FireMissile()
    {
        IMissile missile = PoolingManager.Instance.InstantiatePoolObject(currentMissile.ID, transform.position, transform.rotation).GetComponent<IMissile>();
        missile.Initialise(gameObject.layer);
    }

    public virtual Missile GetMissileByType(MissileType type)
    {
        Missile missile = null;

        foreach (var item in missileTypeData.MissileTypes)
        {
            if (item.MissileType == type)
            {
                missile = item;
                break;
            }
        }

        return missile;
    }

    public virtual void UpdateCurrentMissile(MissileType type)
    {
        currentMissile = GetMissileByType(type);
    }
}
