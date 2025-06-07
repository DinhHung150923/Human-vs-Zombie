using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackBase : IDamageStrategy
{
    // cach gay st theo dps
    protected void DealDamage(DamageReceiver damageReceiver,int dps,float attackInterval)
    {
        int damage = Mathf.CeilToInt(dps *attackInterval);
        if (damageReceiver == null) return;
        damageReceiver.Deduct(damage);
    }
    
    public abstract void Apply(DamageReceiver damageReceiver, int dps, float attackInterval);
}
