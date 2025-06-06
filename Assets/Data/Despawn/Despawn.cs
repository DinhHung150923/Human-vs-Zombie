using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : HungMonoBehaviour
{
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    protected virtual void Despawning()
    {
        if (!this.CanDespawn()) return;
        this.DespawnObj();
    }
    protected virtual void DespawnObj()
    {
        Destroy(transform.parent.gameObject);
    }
    protected abstract bool CanDespawn();
}
