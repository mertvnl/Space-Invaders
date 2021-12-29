using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MissileBase : MonoBehaviour, IMissile
{
    [SerializeField] private MissileData missileData;

    private bool isInitialised;

    public virtual void Initialise(int layerIndex)
    {
        isInitialised = true;
        gameObject.layer = layerIndex;
        DestroyAfterLifeTime();
    }

    public virtual void Update()
    {
        if (!isInitialised) return;

        MoveMissile();
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
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
