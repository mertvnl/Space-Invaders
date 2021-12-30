using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField] private Transform enemyHolder;
    [Range(1,7)]
    [SerializeField] private int width, height;

    private float startingX, endX;

    private void Awake()
    {
        Initialise();
    }

    private void Initialise()
    {
        SetPosition();
        SpawnEnemies();
    }

    private void SetPosition()
    {
        //Set the position on top of camera view depending on res.
        Vector3 newPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1, 0)) + Vector3.down;
        newPos.z = 0;
        transform.position = newPos;

        //Set starting and end offset
        startingX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + 1;
        endX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - 1;

    }

    private void SpawnEnemies()
    {
        Vector3 targetPos = Vector3.zero;
        float xOffset = (Mathf.Abs(startingX) + Mathf.Abs(endX)) / width;
        startingX += xOffset / 2;

        for (int x = 0; x < width; x++)
        {
            float startingY = enemyHolder.localPosition.y;
            for (int y = 0; y < height; y++)
            {
                GameObject enemy = PoolingManager.Instance.InstantiatePoolObject("EnemyShip", GetRandomSpawnPosition(), new Quaternion(0, 0, -180, 0), enemyHolder);
                EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
                targetPos = new Vector3(startingX, startingY, transform.position.z);
                enemyMovement.SetPosition(targetPos);
                startingY--;
            }

            startingX += xOffset;
        }

        ShipManager.Instance.UpdateEnemyShipPositions(5);
    }

    private Vector3 GetRandomSpawnPosition()
    {
        return transform.position + (Vector3)Random.insideUnitCircle + Vector3.up;
    }
}
