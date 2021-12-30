using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissileController : MissileControllerBase
{
    #region Getters
    private PlayerInput playerInput;
    public PlayerInput PlayerInput { get { return playerInput == null ? playerInput = GetComponent<PlayerInput>() : playerInput; } }
    #endregion

    private void Update()
    {
        if (PlayerInput.FireInput && CanFire)
        {
            base.FireMissile();
            StartCoroutine(SetFireRate());
        }
    }
    private IEnumerator SetFireRate()
    {
        CanFire = false;
        yield return new WaitForSeconds(FireRate);
        CanFire = true;
    }


}
