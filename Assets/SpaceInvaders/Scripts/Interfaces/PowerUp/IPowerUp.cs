using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp
{
    void Collect(Ship collectorShip);

    void Move();
    void Dispose();
}
