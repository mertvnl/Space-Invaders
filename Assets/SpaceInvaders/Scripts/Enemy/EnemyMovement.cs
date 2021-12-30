using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float movementDamping;

    private Vector3 targetPosition;

    private void OnEnable()
    {
        Initialise();
    }

    private void Initialise()
    {
        SetPosition(transform.position);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, movementDamping * Time.deltaTime);
    }

    public void SetPosition(Vector3 pos)
    {
        targetPosition = pos;
    }
}
