using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MeleeAttackBase : AttackBase
{
    // tan cong can chien da muc tieu
    //public float attackRadius;
    //public LayerMask targetLayer;
    //// quet tat ca cac colider trong mot vung
    //protected List<GameObject> GetTargetsInRange(Vector3 center)
    //{
    //    Collider[] hits = Physics.OverlapSphere(center, this.attackRadius, this.targetLayer);
    //    List<GameObject> targets = new List<GameObject>();

    //    foreach (var hit in hits)
    //    {
    //        targets.Add(hit.gameObject);
    //    }
    //    return targets;
    //}
}
