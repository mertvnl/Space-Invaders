using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ship
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPowerUp powerUp = collision.GetComponent<IPowerUp>();

        if (powerUp != null)
        {
            powerUp.Collect(this);
        }
    }
}
