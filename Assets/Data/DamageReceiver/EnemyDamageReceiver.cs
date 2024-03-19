using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected SphereCollider sphereCollider;
    protected override void LoadComponent()
    {
        this.LoadSphereCollider();
    }
    protected virtual void LoadSphereCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        sphereCollider.radius = 0.6f;
        Debug.LogWarning(transform.name + " :LoadShereCollider", gameObject);
    }
}
