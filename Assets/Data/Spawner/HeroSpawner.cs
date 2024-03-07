using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : Spawner
{
    [SerializeField] private static HeroSpawner instance;
    public static HeroSpawner Instance => instance;

    protected string prefabOne = "Hero_1";
    public string PrefabOne => prefabOne;
    protected override void Only1Object()
    {
        if (HeroSpawner.instance != null) Debug.LogError("only 1 HeroSpawner to allow");
        HeroSpawner.instance = this; 
    }
}
