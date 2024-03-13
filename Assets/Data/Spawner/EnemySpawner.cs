using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    [SerializeField] private static EnemySpawner instance;
    public static EnemySpawner Instance => instance;

    protected string prefabOne = "Zombie";
    public string PrefabOne => prefabOne;
    protected override void Only1Object()
    {
        if (EnemySpawner.instance != null) Debug.LogError("only 1 ZombieSpawner to allow");
        EnemySpawner.instance = this; 
    }
}
