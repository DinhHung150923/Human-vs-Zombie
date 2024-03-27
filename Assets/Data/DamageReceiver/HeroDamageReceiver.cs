using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class HeroDamageReceiver : DamageReceiver
{
    protected override void SetHpmax()
    {
        this.hpmax = 15;
    }
    protected override void Ondead()
    {
        this.characterCtrl.ModelCtrl.Animator.SetBool("IsDying", true);
        Invoke(nameof(this.DespawnEnemy), this.timeDieDelay);
    }
    protected virtual void DespawnEnemy()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
}
