using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChangeCharToAttack : HungMonobehavior
{
    [Header("Linked Obj")]
    [SerializeField] protected CharacterCtrl characterCtrl;
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected Rigidbody _rigidbody;
    [Header("CharacterAttack")]
    [SerializeField] protected float timer = 0.75f;
    [SerializeField] protected float timeDamage = 1.5f;
    [SerializeField] protected bool isAttacking = false;
    [Header("Target")]
    [SerializeField] protected Transform CurrentDamageReceiver;
    [SerializeField] protected DamageReceiver damageReceiver;
    protected virtual void FixedUpdate()
    {
        this.CheckIsAttacking();
    }
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
        this.characterCtrl =  transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + " :LoadCharacterCtrl", gameObject);
    }
    protected virtual void CheckIsAttacking()
    {
        if (this.isAttacking)
        {
            this.AttackCoolDown(this.CurrentDamageReceiver);
            if (this.CurrentDamageReceiver.transform.parent.gameObject.activeSelf) return;

            this.ReturnToMove();
        }
    }
    protected virtual void AttackCoolDown(Transform obj)
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.timeDamage) return;
        this.timer = 0;

        this.characterCtrl.DamageSender.SendObj(obj);
    }
    protected virtual void ChangeToAttack(Transform obj)
    {
        this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", true);
        this.characterCtrl.Movement.gameObject.SetActive(false);
        this.CurrentDamageReceiver = obj;
        this.isAttacking = true;
    }
    protected virtual void ReturnToMove()
    {
        this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", false);
        this.characterCtrl.Movement.gameObject.SetActive(true);
        this.isAttacking = false;
        this.CurrentDamageReceiver = null;
        this.timer = 0.75f;
    }
    protected abstract void OnTriggerEnter(Collider other);
}
