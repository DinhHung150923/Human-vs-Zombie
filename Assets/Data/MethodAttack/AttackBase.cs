using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackBase : IDamageStrategy
{
    protected int damage = 10;
    protected void DealDamage(GameObject target)
    {
        var receiver = target.GetComponent<DamageReceiver>();
        if (receiver != null)
        {
            receiver.Deduct(damage);
        }
    }
    public abstract void Apply(GameObject attacker);
}
