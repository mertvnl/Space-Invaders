using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : PowerUpBase
{
    public override void Collect(Ship collectorShip)
    {
        ShieldPowerUpEffect effect = collectorShip.GetComponentInChildren<ShieldPowerUpEffect>();

        if (effect == null)
        {
            GameObject powerUp = PoolingManager.Instance.InstantiatePoolObject("PowerUp_Shield", collectorShip.transform.position, collectorShip.transform.rotation, collectorShip.transform);
            powerUp.layer = collectorShip.gameObject.layer;
        }

        base.Collect(collectorShip);
    }
}
