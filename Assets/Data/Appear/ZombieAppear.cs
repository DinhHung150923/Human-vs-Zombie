using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAppear : HungMonobehavior
{
    [SerializeField] protected float time = 0;
    [SerializeField] protected float timeDelay = 1;
    protected virtual void FixedUpdate()
    {
        this.Appearing();
    }
    protected virtual void Appearing()
    {
        this.time += Time.fixedDeltaTime;
        if (this.time < this.timeDelay) return;
        this.time = 0;

        Transform newPrefab = EnemySpawner.Instance.Spawn(EnemySpawner.Instance.PrefabOne, transform.position, transform.rotation);
        newPrefab.gameObject.SetActive(true);
    }
}
