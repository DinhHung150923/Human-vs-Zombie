using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHpPlayer : BaseText
{
    protected virtual void FixedUpdate()
    {
        this.UpdateHp();
    }
    protected virtual void UpdateHp()
    {
        int hp = PlayerCtrl.Instance.DamageReceiver.Hp;
        int hpmax = PlayerCtrl.Instance.DamageReceiver.Hpmax;

        this.text.SetText(hp + " / " + hpmax);
    }
}
