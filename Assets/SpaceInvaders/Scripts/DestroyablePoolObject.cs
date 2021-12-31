using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyablePoolObject : MonoBehaviour, IDestroyable
{
    public void Destroy()
    {
        PoolingManager.Instance.DestroyPoolObject(gameObject);
    }
}
