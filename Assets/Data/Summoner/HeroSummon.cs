using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSummon : HungMonoBehaviour
{
    [SerializeField] protected PlayerCtrl playerCtrl;
    [SerializeField] protected int knightPrize = 20;
    protected override void LoadComponent()
    {
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GetComponentInParent<PlayerCtrl>();
        Debug.LogWarning(transform.name + " :LoadPlayerCtrl", gameObject);
    }
    public virtual void Summon()
    {
       if(this.playerCtrl.CoinManager.Coin >= this.knightPrize)
        {
            this.Summoning();
            Debug.Log("summon knight");
        }
        else
        {
            Debug.Log("not enough coin");
        }
    }
    public virtual void Summoning()
    {
        Transform newPrefab = HeroSpawner.Instance.Spawn(HeroSpawner.Instance.PrefabOne, transform.position, transform.rotation);
        newPrefab.gameObject.SetActive(true);

        this.playerCtrl.CoinManager.DeductCoin(this.knightPrize);
    }
}
