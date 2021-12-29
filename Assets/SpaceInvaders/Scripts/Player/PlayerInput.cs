using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float inputX;
    public float InputX { get { return inputX; } }


    private void Update()
    {
        inputX = Input.GetAxis("Horizontal");
    }
}
