using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : CharDamageReceiver
{
    [SerializeField] protected float ZombiePrize = 10;
    protected override void Ondead()
    {
        this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Dying);
        PlayerCtrl.Instance.CoinManager.Addcoin(this.ZombiePrize);
        this.DespawnEnemy();
    }
    protected virtual void DespawnEnemy()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
}
