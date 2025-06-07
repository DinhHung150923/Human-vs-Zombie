using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]

public abstract class DamageReceiver : HungMonoBehaviour
{
    [SerializeField] protected int hp = 0;
    public int Hp => hp;
    [SerializeField] protected int hpmax = 10;
    public int Hpmax => hpmax;
    [SerializeField] protected int timeDieDelay = 2;
    [SerializeField] protected CircleCollider2D circleCollider2D;
    
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
        this.LoadCircleCollider2D();
    }
    protected virtual void LoadCircleCollider2D()
    {
        if (this.circleCollider2D != null) return;
        this.circleCollider2D = GetComponent<CircleCollider2D>();
        this.circleCollider2D.isTrigger = true;
        this.circleCollider2D.radius = 0.1f;
        Debug.LogWarning(transform.name + " :LoadCircleCollider2D", gameObject);
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
    public virtual bool IsDead()
    {
        if (this.hp == 0) return true;
        return false;
    }
    protected virtual void CheckIsDead()
    {
        if (!this.IsDead()) return;
        this.isDead = true;
        this.Ondead();
    }
    protected virtual void SetHpmax()
    {

    }
    protected abstract void Ondead();
}
