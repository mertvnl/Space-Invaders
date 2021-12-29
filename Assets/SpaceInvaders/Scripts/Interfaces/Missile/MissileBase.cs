using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBase : MonoBehaviour, IMissile
{
    [SerializeField] private MissileData missileData;

    private bool isInitialised;

    public virtual void Initialise()
    {
        isInitialised = true;
        DestroyAfterLifeTime();
    }

    public virtual void Update()
    {
        if (!isInitialised) return;

        MoveMissile();
    }

    private void MoveMissile()
    {
        transform.position += transform.up * missileData.MissileSpeed * Time.deltaTime;
    }

    private void DestroyAfterLifeTime()
    {
        StartCoroutine(DestroyAfterLifeTimeCo());
    }

    private IEnumerator DestroyAfterLifeTimeCo()
    {
        yield return new WaitForSeconds(missileData.MissileLifeTime);
        DestroyMissile();
    }

    private void DestroyMissile()
    {
        //Destroy
    }
}
