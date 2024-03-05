using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDespawn : DespawnByDistance
{
    protected override void DespawnObj()
    {
        HeroSpawner.Instance.DeSpawn(transform.parent);
    }
}
