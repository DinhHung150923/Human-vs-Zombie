using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCoin : BaseText
{
    protected virtual void FixedUpdate()
    {
        this.UpdateTextCoin();
    }
    protected virtual void UpdateTextCoin()
    {
        int coin = (int)PlayerCtrl.Instance.CoinManager.Coin;
        int coinMax = (int)PlayerCtrl.Instance.CoinManager.CoinMax;

        this.text.SetText(coin + " / " + coinMax + "$");
    }
}
