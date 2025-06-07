using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeroDamageReceiver : CharDamageReceiver
{
    protected override void SetHpmax()
    {
        this.hpmax = 15;
    }
    protected override void Ondead()
    {
        this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Dying); 
        this.DespawnEnemy();
    }
    protected virtual void DespawnEnemy()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
}
