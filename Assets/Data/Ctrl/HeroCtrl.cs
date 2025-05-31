using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCtrl : CharacterCtrl
{
    [SerializeField] private static HeroCtrl instance;
    public static HeroCtrl Instance => instance;
    protected override void Only1Script()
    {
        if (HeroCtrl.instance != null) Debug.LogError("only 1 HeroCtrl to allow");
        HeroCtrl.instance = this;
    }
}