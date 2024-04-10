using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnemyStates : ChangeCharToAttack
{
    protected override void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.CompareTag("Hero"))
        {
            this.damageReceiver = other.GetComponent<DamageReceiver>();
            if (this.damageReceiver == null) return;

            this.ChangeToAttack(other.transform);
        }
    }
}
