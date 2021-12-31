using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoUpgradePowerUpEffect : MonoBehaviour
{
    private float duration;
    private Missile lastMissile;

    public void Initialise(float _duration)
    {
        duration = _duration;
        ActivatePowerUp();
    }

    private void ActivatePowerUp()
    {
        StartCoroutine(ActivatePowerUpCo());
    }

    private IEnumerator ActivatePowerUpCo()
    {
        MissileControllerBase mcb = GetComponentInChildren<MissileControllerBase>();

        lastMissile = mcb.CurrentMissile;
        mcb.UpdateCurrentMissile(MissileType.Undestroyable);

        yield return new WaitForSeconds(duration);

        mcb.UpdateCurrentMissile(lastMissile.MissileType);
        Destroy(this);
    }

}
