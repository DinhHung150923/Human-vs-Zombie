using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSummonHerro : BaseButton
{
    protected override void Onclick()
    {
        PlayerCtrl.Instance.HeroSummon.Summon();
    }
}
