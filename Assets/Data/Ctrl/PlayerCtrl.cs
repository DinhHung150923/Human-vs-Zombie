using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : HungMonobehavior
{
    [SerializeField] private static PlayerCtrl instance;
    public static PlayerCtrl Instance => instance;
    [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver => damageReceiver;
    protected override void Only1Script()
    {
        if (PlayerCtrl.instance != null) Debug.LogError("only 1 HeroSpawner to allow");
        PlayerCtrl.instance = this;
    }
    protected override void LoadComponent()
    {
        this.LoadDamageReceiver();
    }
    protected virtual void LoadDamageReceiver()
    {
        if (this.damageReceiver != null) return;
        this.damageReceiver = GetComponentInChildren<DamageReceiver>();
        Debug.LogWarning(transform.name + " :LoadDamageReceiver", gameObject);
    }
}
