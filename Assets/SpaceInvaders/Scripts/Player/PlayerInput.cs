using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float inputX;
    public float InputX { get { return inputX; } }

    private bool fireInput;
    public bool FireInput { get { return fireInput; } }

    private void Update()
    {
        GetInputs();
    }

    private void GetInputs()
    {
        inputX = Input.GetAxis("Horizontal");
        fireInput = Input.GetKeyDown(KeyCode.Space);
    }
}
