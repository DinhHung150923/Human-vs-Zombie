using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharAttack : HungMonoBehaviour
{
    [SerializeField]protected int dps = 1; // dmg per second
    [SerializeField]protected float attackInterval = 1f; // delaytime attack
    protected Coroutine attackCoroutine;
    protected IDamageStrategy damageStrategy;
   
    public virtual void Attack(DamageReceiver damageReceiver)
    {
        
        if (damageReceiver == null) this.StopAttacking();
        if (damageReceiver != null) this.StartAttacking(damageReceiver, this.dps, this.attackInterval);
    }
    protected virtual void StartAttacking(DamageReceiver damageReceiver , int dps, float attackInterval)
    {
        if (attackCoroutine == null)
        {
            attackCoroutine = StartCoroutine(this.AttackRoutine(damageReceiver, dps, attackInterval));
        }
    }
    protected virtual void StopAttacking()
    {
        if (attackCoroutine != null)
        {
            StopCoroutine(attackCoroutine);
            attackCoroutine = null;
        }
    }
    protected abstract IEnumerator AttackRoutine(DamageReceiver damageReceiver, int dps, float attackInterval);
}
