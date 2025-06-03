using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : CharAttack
{
    protected override void Start()
    {
        this.damageStrategy = new MeleeSingleAttack();
    }
    protected override IEnumerator AttackRoutine(Transform obj, int dps, float attackInterval)
    {
        while (true)
        {
            yield return new WaitForSeconds(attackInterval);
            if (obj != null)
            {
                this.damageStrategy.Apply(obj, dps, attackInterval);
            }
        }
    }
}