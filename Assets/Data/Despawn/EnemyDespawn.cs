using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawn : Despawn
{
    [SerializeField] protected CharacterCtrl characterCtrl;
    protected override void LoadComponent()
    {
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = GetComponentInParent<CharacterCtrl>();
    }
    protected override void DespawnObj()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
    protected override bool CanDespawn()
    {
        return this.characterCtrl.DamageReceiver.Isdead();
    }
}
