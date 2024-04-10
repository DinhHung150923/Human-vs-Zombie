using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAppear : HungMonobehavior
{
    [SerializeField] protected float time = 0;
    [SerializeField] protected float timeDelay = 3;
    protected virtual void FixedUpdate()
    {
        this.Appearing();
    }
    protected virtual void Appearing()
    {
        this.time += Time.fixedDeltaTime;
        if (this.time < this.timeDelay) return;
        this.time = 0;

        Transform newPrefab = HeroSpawner.Instance.Spawn(HeroSpawner.Instance.PrefabOne, transform.position, transform.rotation);
        newPrefab.gameObject.SetActive(true);
    }
}
