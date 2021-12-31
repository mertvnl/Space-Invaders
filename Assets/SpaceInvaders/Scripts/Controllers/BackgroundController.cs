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
        FitToScreen();
    }

    private void FitToScreen()
    {
        //Fit background to screen size and scale up the texture
        Vector3 screen2World = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector3 targetScale = new Vector3(screen2World.x * 2, screen2World.y + 1, transform.localScale.z);
        transform.localScale = targetScale;
        Material.mainTextureScale = (Vector2)targetScale / 4;
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
