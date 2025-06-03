using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamageSender : DamageSender
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent.CompareTag("Hero"))
        {
            Debug.Log(other.transform);
            this.characterCtrl.CharAttack.Attack(other.transform);
            this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Attacking);
        }
    }
}
