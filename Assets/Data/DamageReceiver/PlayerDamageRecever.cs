using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageRecever : DamageReceiver
{
    protected override void LoadSphereCollider()
    {
        base.LoadSphereCollider();
        this.sphereCollider.radius = 1.3f;
    }
    protected override void SetHpmax()
    {
        this.hpmax = 50;
    }
    protected override void Ondead()
    {
        throw new System.NotImplementedException();
    }

}
