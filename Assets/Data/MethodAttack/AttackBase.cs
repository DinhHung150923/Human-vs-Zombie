using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackBase : IDamageStrategy
{
    protected int damage = 1;
    protected float timer = 0;
    protected float delayTimer = 1;
    

    protected void DelayAttack(GameObject target)
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer <= this.delayTimer) return;
        this.timer = 0;

        this.DealDamage(target);
    }
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
