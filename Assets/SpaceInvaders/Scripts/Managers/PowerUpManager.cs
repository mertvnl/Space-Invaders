using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : Singleton<PowerUpManager>
{
    [SerializeField] private PowerUpData powerUpData;

    [Range(0f, 1f)]
    [SerializeField] private float powerUpDropRate;

    public void DropPowerUp(Vector3 pos)
    {
        if (Random.value <= powerUpDropRate)
        {
            PoolingManager.Instance.InstantiatePoolObject(GetRandomPowerUpByID(), pos);
        }
    }

    private string GetRandomPowerUpByID()
    {
        int randomIndex = Random.Range(0, powerUpData.PowerUpIDS.Length);

        return powerUpData.PowerUpIDS[randomIndex];
    }
}
