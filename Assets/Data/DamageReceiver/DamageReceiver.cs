using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class DamageReceiver : HungMonobehavior
{
    [SerializeField] protected int hp = 0;
    [SerializeField] protected int hpmax = 10;
    [SerializeField] protected int timeDieDelay = 2;
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected CharacterCtrl characterCtrl;
    protected override void Reset()
    {
        base.Reset();
        this.SetHpmax();
    }
    protected override void LoadComponent()
    {
        this.LoadSphereCollider();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = GetComponentInParent<CharacterCtrl>();
        Debug.LogWarning(transform.name + "LoadCharacterCtrl :", gameObject);
    }
    protected virtual void LoadSphereCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        sphereCollider.radius = 0.6f;
        Debug.LogWarning(transform.name + " :LoadShereCollider", gameObject);
    }
    protected override void Start()
    {
        base.Start();
        this.Reborn();
    }
    protected virtual void FixedUpdate()
    {
        this.CheckIsDead();
    }
    protected virtual void Reborn()
    {
        this.hp = this.hpmax;
    }
    public virtual void Deduct(int deduct)
    {
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
        this.Ondead();
    }
    protected virtual void SetHpmax()
    {

    }
    protected abstract void Ondead();
}
