using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : HungMonobehavior
{
    [SerializeField] protected ModelCtrl modelCtrl;
    public ModelCtrl ModelCtrl => modelCtrl;
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender => damageSender;
    [SerializeField] protected Movement movement;
    public Movement Movement => movement;
    protected override void LoadComponent()
    {
        this.LoadModel();
        this.LoadDamageSender();
        this.LoadHeroMovement();
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
}