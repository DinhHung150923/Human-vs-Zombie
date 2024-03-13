using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDespawn : DespawnByDistance
{
    protected override void DespawnObj()
    {
        HeroSpawner.Instance.DeSpawn(transform.parent);
    }
}
