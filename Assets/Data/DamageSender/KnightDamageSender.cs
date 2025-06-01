using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightDamageSender : DamageSender
{
    protected override void Start()
    {
        this.damageStrategy = new MeleeSingleAttack();
    }
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.transform.parent.CompareTag("Enemy"))
        {
            this.damageStrategy?.Apply(other.gameObject);
            this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Attacking);
        }
    }
}
