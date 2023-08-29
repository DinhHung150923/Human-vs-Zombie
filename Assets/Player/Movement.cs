using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 1f;
    protected virtual void FixedUpdate()
    {
        this.SnakeSlip();
    }
    protected virtual void SnakeSlip()
    {
        Vector3 direction = InputManager.Instance.CurrentDirection;
        transform.parent.Translate( direction* this.speed * Time.fixedDeltaTime);
    }
}
