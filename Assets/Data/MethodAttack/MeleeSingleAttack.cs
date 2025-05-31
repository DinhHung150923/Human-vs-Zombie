using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSingleAttack : MeleeAttackBase
{
    public override void Apply(GameObject target)
    {
        if (target == null) return;
        DealDamage(target);
    }
}
