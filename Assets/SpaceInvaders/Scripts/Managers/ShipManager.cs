using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : Singleton<ShipManager>
{
    [SerializeField] private float enemyShipsMovementUpdateDelay = 7.5f;
    [SerializeField] private float enemyShipIndividualDelay = 0.05f;

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

    public void UpdateEnemyShipPositions(float initialDelay)
    {
        StartCoroutine(UpdateEnemyShipPositionsCo(initialDelay));
    }

    private IEnumerator UpdateEnemyShipPositionsCo(float initialDelay)
    {
        yield return new WaitForSeconds(initialDelay);

        while (true)
        {
            float delay = enemyShipIndividualDelay;

            for (int i = Ships.Count - 1; i >= 0; i--)
            {
                if (Ships[i].ShipControllerType == ShipControllerType.Enemy)
                {
                    Ships[i].GetComponent<EnemyMovement>().SetPosition(Vector3.down / 2, delay);
                    delay += enemyShipIndividualDelay;
                }
            }

            yield return new WaitForSeconds(enemyShipsMovementUpdateDelay);
        }
    }
}
