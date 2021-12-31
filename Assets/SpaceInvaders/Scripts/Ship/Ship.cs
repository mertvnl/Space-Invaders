using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ShipControllerType
{
    Player,
    Enemy
}

public class Ship : MonoBehaviour, IDestroyable
{
    public ShipControllerType ShipControllerType;

    public void OnEnable()
    {
        Initialise();
    }

    public void OnDisable()
    {
        Dispose();
    }

    public virtual void Initialise()
    {
        if (Managers.Instance == null) return;

        ShipManager.Instance.AddShip(this);
    }

    public virtual void Dispose()
    {
        if (Managers.Instance == null) return;

        ShipManager.Instance.RemoveShip(this);
    }

    public virtual void Destroy()
    {
        PoolingManager.Instance.DestroyPoolObject(gameObject);
        //Destroy fx
    }
}
