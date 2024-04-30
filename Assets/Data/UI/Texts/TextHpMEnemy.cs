using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHpMEnemy : BaseText
{
    protected virtual void FixedUpdate()
    {
        this.UpdateHp();
    }
    protected virtual void UpdateHp()
    {
        int hp = MEnemyCtrl.Instance.DamageReceiver.Hp;
        int hpmax = MEnemyCtrl.Instance.DamageReceiver.Hpmax;

        this.text.SetText(hp + " / " + hpmax);
    }
}
