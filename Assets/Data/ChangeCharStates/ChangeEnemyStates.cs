using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnemyStates : ChangeCharStates
{
    [SerializeField] protected float timer = 0;
    [SerializeField] protected float timeDamage = 1.5f;
    [SerializeField] protected bool isAttacking = false;
    protected override void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.CompareTag("Hero"))
        {
            this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", true);
            this.characterCtrl.Movement.gameObject.SetActive(false);
            this.isAttacking = true;
        }
    }
    protected virtual void OnTriggerStay(Collider other)
    {
        if (other.transform.parent.CompareTag("Hero"))
        {
            this.AttackCoolDown(other.transform);
        }
    }
    protected virtual void AttackCoolDown(Transform obj)
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.timeDamage) return;
        this.timer = 0;

        this.characterCtrl.DamageSender.SendObj(obj);
    }
}
