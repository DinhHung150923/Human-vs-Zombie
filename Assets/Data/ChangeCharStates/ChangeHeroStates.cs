using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeroStates : ChangeCharToAttack
{
    protected override void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.CompareTag("Enemy"))
        {
            this.damageReceiver = other.GetComponent<DamageReceiver>();
            if (this.damageReceiver == null) return;

            this.ChangeToAttack(other.transform);
        }
    }
}
