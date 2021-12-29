using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointHolder : MonoBehaviour
{
    [SerializeField] private Transform mainFirePoint;

    public Transform GetFirePoint()
    {
        return mainFirePoint;
    }
}
