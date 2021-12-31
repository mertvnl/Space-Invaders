using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Ship
{
    public override void Destroy()
    {
        base.Destroy();

        PowerUpManager.Instance.DropPowerUp(transform.position);
    }
}
