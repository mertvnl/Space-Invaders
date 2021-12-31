using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoUpgradePowerUp : PowerUpBase
{
    [SerializeField] private float powerUpDuration = 5f;

    public override void Collect(Ship collectorShip)
    {
        AmmoUpgradePowerUpEffect effect = collectorShip.GetComponentInChildren<AmmoUpgradePowerUpEffect>();

        if (effect == null)
        {
            collectorShip.gameObject.AddComponent<AmmoUpgradePowerUpEffect>().Initialise(powerUpDuration);
        }

        base.Collect(collectorShip);
    }
}
