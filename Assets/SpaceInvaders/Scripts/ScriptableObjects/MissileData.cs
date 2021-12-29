using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewMissileData", menuName = "MissileData", order = 1)]
public class MissileData : ScriptableObject
{
    [Header("Missile Settings")]
    [Space]
    public float MissileSpeed;
    public float MissileLifeTime;
    public bool DontDestroyOnCollision;
}
