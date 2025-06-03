using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharAttack : HungMonoBehaviour
{
    [SerializeField]protected int dps = 1; // dmg per second
    [SerializeField]protected float attackInterval = 1f; // delaytime attack
    protected Coroutine attackCoroutine;
    protected IDamageStrategy damageStrategy;
   
    public virtual void Attack(Transform obj)
    {
        
        if (obj == null) this.StopAttacking();
        if (obj!= null) this.StartAttacking(obj, this.dps, this.attackInterval);
    }
    protected virtual void StartAttacking(Transform obj , int dps, float attackInterval)
    {
        if (attackCoroutine == null)
        {
            attackCoroutine = StartCoroutine(this.AttackRoutine(obj, dps, attackInterval));
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
    protected abstract IEnumerator AttackRoutine(Transform obj, int dps, float attackInterval);
}
