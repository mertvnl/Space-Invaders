using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Getters
    private PlayerInput playerInput;
    public PlayerInput PlayerInput { get { return playerInput == null ? playerInput = GetComponent<PlayerInput>() : playerInput; } }
    #endregion

    public float speed;


    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 newPos = transform.position;
        newPos.x += PlayerInput.InputX * speed * Time.deltaTime;
        transform.position = newPos;

        KeepInScreenBounds();
    }

    private void KeepInScreenBounds()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
