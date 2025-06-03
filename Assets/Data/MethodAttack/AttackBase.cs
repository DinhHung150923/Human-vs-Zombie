using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackBase : IDamageStrategy
{
    protected void DealDamage(Transform obj,int dps,float attackInterval)
    {
        int damage = Mathf.CeilToInt(dps *attackInterval);
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        //Debug.Log(damageReceiver);
        if (damageReceiver == null) return;
        Debug.Log("attack");
        damageReceiver.Deduct(damage);
    }
    
    public abstract void Apply(Transform obj, int dps, float attackInterval);
}
