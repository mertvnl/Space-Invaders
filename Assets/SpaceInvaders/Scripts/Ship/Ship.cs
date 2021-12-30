using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShipControllerType
{
    Player,
    Enemy
}

public class Ship : MonoBehaviour
{
    public ShipControllerType ShipControllerType;
    public void Awake()
    {
        Initialise();
    }

    public void OnDisable()
    {
        Dispose();
    }

    public void Initialise()
    {
        if (Managers.Instance == null) return;

        ShipManager.Instance.AddShip(this);
    }

    public void Dispose()
    {
        if (Managers.Instance == null) return;

        ShipManager.Instance.RemoveShip(this);
        //Dispose particle
    }
}
