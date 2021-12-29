using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileController : MissileControllerBase
{
    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void Awake()
    {
        Initialise();    
    }

    private void Initialise()
    {
        SetRandomFireRate();
        ActivateFiring();
    }

    private void ActivateFiring()
    {
        StartCoroutine(FireAutomaticallyCo());
    }

    private IEnumerator FireAutomaticallyCo()
    {
        while (CanFire)
        {
            yield return new WaitForSeconds(FireRate);
            base.FireMissile();
        }
    }

    private void SetRandomFireRate()
    {
        FireRate = UnityEngine.Random.Range(5f, 25f);
    }
}
