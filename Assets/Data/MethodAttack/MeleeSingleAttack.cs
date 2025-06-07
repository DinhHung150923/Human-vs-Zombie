using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSingleAttack : MeleeAttackBase
{
    // kieu tan cong can chien don muc tieu
    public override void Apply(DamageReceiver damageReceiver, int dps, float attackInterval)
    {
        if (damageReceiver == null) return;
        this.DealDamage(damageReceiver, dps, attackInterval);
    }
}
