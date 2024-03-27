using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawn : Despawn
{
    protected override void DespawnObj()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
    protected override bool CanDespawn()
    {
        throw new System.NotImplementedException();
    }
}
