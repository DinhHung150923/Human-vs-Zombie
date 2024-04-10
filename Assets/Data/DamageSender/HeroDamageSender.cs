using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDamageSender : DamageSender
{
    protected override void SetDamage()
    {
        this.damage = 3;
    }
}
