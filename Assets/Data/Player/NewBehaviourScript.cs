using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : HungMonobehavior
{
    [SerializeField] protected float time = 0;
    [SerializeField] protected float timeDelay = 1;
    protected virtual void FixedUpdate()
    {
        this.HeroAppear();
    }
    protected virtual void HeroAppear()
    {
        this.time += Time.fixedDeltaTime;
        if (this.time < this.timeDelay) return;
        this.time = 0;

        Transform newHero = HeroSpawner.Instance.Spawn(HeroSpawner.Instance.PrefabOne, transform.position, transform.rotation);
        newHero.gameObject.SetActive(true);
    }
}
