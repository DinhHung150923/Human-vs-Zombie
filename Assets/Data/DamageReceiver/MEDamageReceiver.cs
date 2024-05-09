using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEDamageReceiver : DamageReceiver
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
        UIManagerInGame.Instance.VictoryScreen.SetActive(true);
    }
}
