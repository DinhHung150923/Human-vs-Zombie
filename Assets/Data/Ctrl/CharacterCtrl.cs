using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterCtrl : HungMonobehavior
{
    [SerializeField] protected ModelCtrl modelCtrl;
    public ModelCtrl ModelCtrl => modelCtrl;
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender => damageSender;
    [SerializeField] protected Movement movement;
    public Movement Movement => movement;
    [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver => damageReceiver;
    protected override void LoadComponent()
    {
        this.LoadModel();
        this.LoadDamageSender();
        this.LoadHeroMovement();
        this.LoadDamageReceiver();
    }
    protected virtual void LoadModel()
    {
        if (this.modelCtrl != null) return;
        this.modelCtrl = GetComponentInChildren<ModelCtrl>();
        Debug.LogWarning(transform.name + " :LoadModel", gameObject);
    }
    protected virtual void LoadDamageSender()
    {
        if (this.damageSender != null) return;
        this.damageSender = GetComponentInChildren<DamageSender>();
        Debug.LogWarning(transform.name + " :LoadDamageSender", gameObject);
    }
    protected virtual void LoadHeroMovement()
    {
        if (this.movement != null) return;
        this.movement = GetComponentInChildren<Movement>();
        Debug.LogWarning(transform.name + " :LoadMovement", gameObject);
    }
    protected virtual void LoadDamageReceiver()
    {
        if (this.damageReceiver != null) return;
        this.damageReceiver = GetComponentInChildren<DamageReceiver>();
        Debug.LogWarning(transform.name + " :LoadDamageReceiver", gameObject);
    }
}
