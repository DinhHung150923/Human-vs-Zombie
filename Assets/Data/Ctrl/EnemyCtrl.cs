using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : CharacterCtrl
{
    [SerializeField] private static EnemyCtrl instance;
    public static EnemyCtrl Instance => instance;
    protected override void Only1Script()
    {
        if (EnemyCtrl.instance != null) Debug.LogError("only 1 EnemyCtrl to allow");
        EnemyCtrl.instance = this;
    }
}