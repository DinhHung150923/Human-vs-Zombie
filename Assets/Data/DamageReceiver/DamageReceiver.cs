using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]

public abstract class DamageReceiver : HungMonobehavior
{
    [SerializeField] protected int hp = 0;
    public int Hp => hp;
    [SerializeField] protected int hpmax = 10;
    public int Hpmax => hpmax;
    [SerializeField] protected int timeDieDelay = 2;
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected bool isDead = false;
    protected override void Reset()
    {
        base.Reset();
        this.SetHpmax();
    }
    protected void OnEnable()
    {
        this.Reborn();
    }
    protected override void LoadComponent()
    {
        this.LoadSphereCollider();
    }
    protected virtual void LoadSphereCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        this.sphereCollider.isTrigger = true;
        this.sphereCollider.radius = 0.1f;
        Debug.LogWarning(transform.name + " :LoadShereCollider", gameObject);
    }
    protected virtual void FixedUpdate()
    {
        this.CheckIsDead();
    }
    protected virtual void Reborn()
    {
        this.hp = this.hpmax;
        this.isDead = false;
    }
    public virtual void Deduct(int deduct)
    {
        if (this.isDead) return;

        this.hp -= deduct;
        if (this.hp < 0) this.hp = 0;
    }
    public virtual bool Isdead()
    {
        if (this.hp == 0) return true;
        return false;
    }
    protected virtual void CheckIsDead()
    {
        if (!this.Isdead()) return;
        this.isDead = true;
        this.Ondead();
    }
    protected virtual void SetHpmax()
    {

    }
    protected abstract void Ondead();
}
