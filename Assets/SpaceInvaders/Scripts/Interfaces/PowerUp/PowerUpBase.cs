using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour, IPowerUp
{
    [SerializeField] private float movementSpeed = 2f;
    public virtual void Collect(Ship collectorShip)
    {
        Dispose();
    }

    public virtual void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;
    }

    public virtual void Dispose()
    {
        PoolingManager.Instance.DestroyPoolObject(gameObject);
    }
}
