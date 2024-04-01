using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnemyStates : ChangeCharStates
{
    protected virtual void FixedUpdate()
    {
        this.CheckIsAttacking();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.CompareTag("Hero"))
        {
            this.damageReceiver = other.GetComponent<DamageReceiver>();
            if (this.damageReceiver == null) return;

            this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", true);
            this.characterCtrl.Movement.gameObject.SetActive(false);
            this.CurrentObj = other.transform.parent;
            this.isAttacking = true;
        }
    }
    protected virtual void CheckIsAttacking()
    {
        if (this.isAttacking == true)
        {
            this.AttackCoolDown(this.damageReceiver.transform);
            if (this.CurrentObj.gameObject.activeSelf) return;
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
    protected virtual void ReturnToMove()
    {
        this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", false);
        this.characterCtrl.Movement.gameObject.SetActive(true);
        this.isAttacking = false;
        this.CurrentObj = null;
    }
}
