using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChangeCharToAttack : ChangeCharStates
{
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
