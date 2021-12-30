using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewMissileTypeData", menuName = "MissileData/TypeData", order = 1)]

public class MissileTypeData : ScriptableObject
{
    [Header("Missile Types")]
    [Space]

    public Missile[] MissileTypes;
}

[System.Serializable]
public class Missile
{
    public MissileType MissileType;
    public string ID;
}

public enum MissileType
{
    Default_Player,
    Default_Enemy,
    Undestroyable
}
