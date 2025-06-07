using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : CharAttack
{
    protected override void Start()
    {
        this.damageStrategy = new MeleeSingleAttack();
    }
    protected override IEnumerator AttackRoutine(DamageReceiver damageReceiver, int dps, float attackInterval)
    {
        while (true)
        {
            yield return new WaitForSeconds(attackInterval);
            if (damageReceiver != null)
            {
                this.damageStrategy.Apply(damageReceiver, dps, attackInterval);
            }
        }
    }
}
