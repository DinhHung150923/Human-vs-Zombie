using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSender : DamageSender
{
    protected override void SetDamage()
    {
        this.damage = 2;
    }
}
