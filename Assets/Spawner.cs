using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : HungMonobehavior
{
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> Holders;
    protected override void LoadComponent()
    {
        this.LoadPrefab();
    }
    protected override void Awake()
    {
        this.HidePrefab();
    }
    protected virtual void LoadPrefab()
    {
        Transform prefabObj = transform.Find("Prefab");
        foreach (Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }
        
    }
    protected virtual void HidePrefab()
    {
        foreach(Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
}
