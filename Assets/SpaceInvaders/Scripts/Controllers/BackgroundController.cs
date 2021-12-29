using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    #region Getters
    private Material material;
    public Material Material { get { return material == null ? material = GetComponent<Renderer>().material : material; } }
    #endregion

    [SerializeField] private float backgroundSpeed;

    private Vector2 backgroundMovementAxis;

    private void Awake()
    {
        SetRandomDirection();    
    }

    private void SetRandomDirection()
    {
        backgroundMovementAxis = new Vector2(Random.Range(-1f, 1f), 1);
    }

    private void Update()
    {
        if (Material == null)
            return;

        Material.mainTextureOffset += backgroundMovementAxis * backgroundSpeed * Time.deltaTime;
    }
}
