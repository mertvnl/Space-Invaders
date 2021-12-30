using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    private void Awake()
    {
        Initialise();
    }

    private void Initialise()
    {
        SetPosition();
    }

    private void SetPosition()
    {
        //Set the position on top of camera view depending on res.
        Vector3 newPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1, 0));
        newPos.z = 0;
        transform.position = newPos;
    }

    private void SpawnEnemies()
    {

    }

    private Vector3 GetRandomSpawnPosition()
    {
        return transform.position + (Vector3)Random.insideUnitCircle + Vector3.up;
    }
}
