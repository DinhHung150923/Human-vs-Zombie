using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamageSender : CharDamageSender
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        DamageReceiver receiver = other.GetComponent<DamageReceiver>();
        if (other.transform.parent.CompareTag("Hero") & receiver != null)
        {
            this.characterCtrl.CharAttack.Attack(receiver);
            this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Attacking);
        }
    }
    //protected void OnTriggerStay2D(Collider2D other)
    //{
    //    if (!other.transform.parent.CompareTag("Hero")) this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Moving);
    //}
}
