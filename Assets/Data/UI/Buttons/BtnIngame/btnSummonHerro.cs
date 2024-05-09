using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnSummonHerro : BaseButton
{
    protected override void Onclick()
    {
        PlayerCtrl.Instance.HeroSummon.Summon();
    }
}
