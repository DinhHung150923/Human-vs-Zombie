using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSingleAttack : MeleeAttackBase
{
    public override void Apply(Transform obj, int dps, float attackInterval)
    {
        if (obj == null) return;
        this.DealDamage(obj, dps, attackInterval);
    }
}
