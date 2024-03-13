using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : Movement
{
    protected override void prefabMovement()
    {
        this.direction = Vector3.right;
        base.prefabMovement();
    }
}
