using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : HungMonobehavior
{
    [SerializeField] protected int hp = 0;
    [SerializeField] protected int hpmax = 10;
    protected override void Start()
    {
        this.Reborn();
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
}
