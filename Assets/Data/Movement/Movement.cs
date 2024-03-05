using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 5f;
    protected virtual void FixedUpdate()
    {
        this.prefabMovement();
    }
    protected virtual void prefabMovement()
    {
        Vector3 direction = Vector3.right;
        transform.parent.Translate( direction* this.speed * Time.fixedDeltaTime);
    }
}
