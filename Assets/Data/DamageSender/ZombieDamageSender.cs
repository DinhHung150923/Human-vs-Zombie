using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamageSender : DamageSender
{
    protected override void Start()
    {
        this.damageStrategy = new MeleeSingleAttack();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.CompareTag("Hero"))
        {
            this.damageStrategy?.Apply(other.gameObject);
            this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Attacking);
        }
    }
}
