using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : HungMonoBehaviour
{
    [SerializeField] protected float coin = 1;
    public float Coin => coin;
    [SerializeField] protected float coinUp = 3;
    [SerializeField] protected float coinMax = 100;
    public float CoinMax => coinMax;
    protected virtual void FixedUpdate()
    {
        this.AddCoinFolowTime();
    }
    protected virtual void AddCoinFolowTime()
    {
        this.coin += this.coinUp * Time.fixedDeltaTime;
        if (this.coin >= this.coinMax) this.coin = this.coinMax;
    }
    public virtual void Addcoin(float coin)
    {
        this.coin += coin;
        if (this.coin >= this.coinMax) this.coin = this.coinMax;
    }
    public virtual void DeductCoin(float coin)
    {
        this.coin -= coin;
        if (this.coin <= 0) this.coin = 0;
    }
}
