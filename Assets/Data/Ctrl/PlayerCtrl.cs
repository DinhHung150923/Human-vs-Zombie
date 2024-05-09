using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : HungMonobehavior
{
    [SerializeField] private static PlayerCtrl instance;
    public static PlayerCtrl Instance => instance;
    [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver => damageReceiver;
    [SerializeField] protected HeroSummon heroSummon;
    public HeroSummon HeroSummon => heroSummon;
    [SerializeField] protected CoinManager coinManager;
    public CoinManager CoinManager => coinManager;
    protected override void Only1Script()
    {
        if (PlayerCtrl.instance != null) Debug.LogError("only 1 PlayerCtrl to allow");
        PlayerCtrl.instance = this;
    }
    protected override void LoadComponent()
    {
        this.LoadDamageReceiver();
        this.LoadHerroAppear();
        this.LoadCoinManager();
    }
    protected virtual void LoadDamageReceiver()
    {
        if (this.damageReceiver != null) return;
        this.damageReceiver = GetComponentInChildren<DamageReceiver>();
        Debug.LogWarning(transform.name + " :LoadDamageReceiver", gameObject);
    }
    protected virtual void LoadHerroAppear()
    {
        if (this.heroSummon != null) return;
        this.heroSummon = GetComponentInChildren<HeroSummon>();
        Debug.LogWarning(transform.name + " :LoadHeroSummon", gameObject);
    }
    protected virtual void LoadCoinManager()
    {
        if (this.coinManager != null) return;
        this.coinManager = GetComponentInChildren<CoinManager>();
        Debug.LogWarning(transform.name + " :LoadCoinManager", gameObject);
    }
}
