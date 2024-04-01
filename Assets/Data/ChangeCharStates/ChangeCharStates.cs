using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChangeCharStates : HungMonobehavior
{
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected Rigidbody _rigidbody;
    [SerializeField] protected CharacterCtrl characterCtrl;
    [Header("CharacterState")]
    [SerializeField] protected float timer = 0.75f;
    [SerializeField] protected float timeDamage = 1.5f;
    [SerializeField] protected Transform CurrentObj;
    [SerializeField] protected DamageReceiver damageReceiver;
    [SerializeField] protected bool isAttacking = false;
    protected override void LoadComponent()
    {
        this.LoadSphereCollider();
        this.LoadRigibody();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadSphereCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        this.sphereCollider.isTrigger = true;
        this.sphereCollider.radius = 0.6f;
        Debug.LogWarning(transform.name + " :LoadSphereCollider", gameObject);
    }
    protected virtual void LoadRigibody()
    {
        if (this._rigidbody != null) return;
        this._rigidbody = GetComponent<Rigidbody>();
        this._rigidbody.isKinematic = true;
        Debug.LogWarning(transform.name + " :LoadRigibody", gameObject);
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = GetComponentInParent<CharacterCtrl>();
        Debug.LogWarning(transform.name + " :LoadCharacterCtrl", gameObject);
    }
    protected abstract void OnTriggerEnter(Collider other);
}
