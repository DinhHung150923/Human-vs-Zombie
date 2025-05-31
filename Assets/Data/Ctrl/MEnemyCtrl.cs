using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEnemyCtrl : HungMonoBehaviour
{
    [SerializeField] private static MEnemyCtrl instance;
    public static MEnemyCtrl Instance => instance;
    [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver => damageReceiver;
    protected override void Only1Script()
    {
        if (MEnemyCtrl.instance != null) Debug.LogError("only 1 HeroSpawner to allow");
        MEnemyCtrl.instance = this;
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
