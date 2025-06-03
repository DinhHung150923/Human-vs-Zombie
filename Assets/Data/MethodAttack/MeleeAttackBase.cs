using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MeleeAttackBase : AttackBase
{
    //public float attackRadius;
    
    // quet tat ca cac colider trong mot vung
    //protected List<GameObject> GetTargetsInRange(Vector2 center)
    //{
    //    Collider2D[] hits = Physics2D.OverlapCircleAll(center,this.attackRadius);
    //    List<GameObject> targets = new List<GameObject>();

    //    foreach (Collider2D hit in hits)
    //    {
    //        targets.Add(hit.gameObject);
    //    }
    //    return targets;
    //}

    //protected void Attack(GameObject target )
    //{
    //    if (target == null) this.StopAttacking();
    //    if (target != null) this.StartAttacking(target);
    //}
}
