using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : Singleton<ShipManager>
{
    public List<Ship> Ships = new List<Ship>();

    public void CheckGameState()
    {
        if (Ships.Count == 1)
        {
            if (Ships[0].ShipControllerType == ShipControllerType.Player)
            {
                Debug.Log("Win");
                //win
            }
        }
    }

    public void AddShip(Ship ship)
    {
        if (!Ships.Contains(ship))
        {
            Ships.Add(ship);
        }
    }

    public void RemoveShip(Ship ship)
    {
        if (Ships.Contains(ship))
        {
            Ships.Remove(ship);
            if (ship.ShipControllerType == ShipControllerType.Player)
            {
                Debug.Log("Lose");
                //lose
            }

            CheckGameState();
        }
    }
}
