using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : HungMonobehavior
{
    [SerializeField] protected float speed = 2f;
     protected Vector3 direction;
    protected virtual void FixedUpdate()
    {
        this.prefabMovement();
    }
    protected virtual void prefabMovement()
    {
        transform.parent.Translate( direction* this.speed * Time.fixedDeltaTime);
    }
}
