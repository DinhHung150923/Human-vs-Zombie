using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected float ZombiePrize = 10;
    [SerializeField] protected CharacterCtrl characterCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + "LoadCharacterCtrl :", gameObject);
    }
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
