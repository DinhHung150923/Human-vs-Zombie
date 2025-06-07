using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class DamageSender : HungMonoBehaviour
{
    [Header("Linked Obj")]
    [SerializeField] protected CircleCollider2D circleCollider2D;
    
    protected override void LoadComponent()
    {
        this.LoadCircleCollider2D();
    }
    protected virtual void LoadCircleCollider2D()
    {
        if (this.circleCollider2D != null) return;
        this.circleCollider2D = GetComponent<CircleCollider2D>();
        this.circleCollider2D.isTrigger = true;
        this.circleCollider2D.radius = 0.6f;
        Debug.LogWarning(transform.name + " :LoadCircleCollider2D", gameObject);
    }
    
    protected abstract void OnTriggerEnter2D(Collider2D other);
}
