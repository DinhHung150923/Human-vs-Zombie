using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : HungMonobehavior
{
    [SerializeField] protected float timer = 0;
    [SerializeField] protected float timeDelay = 1;
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected Transform Obj;
    [SerializeField] protected Transform Holder;
    protected int spawnCount = 4;
    protected override void LoadComponent()
    {
        this.LoadPrefab();
        this.LoadHolder();
    }
    protected override void Awake()
    {
        this.HidePrefab();
    }
    protected virtual void FixedUpdate()
    {
        this.Spawn();
    }
    protected virtual void LoadHolder()
    {
        if (this.Holder != null) return;
        this.Holder = transform.Find("Holder");
        Debug.LogWarning(transform.name+ "LoadHolder", gameObject);
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
    public virtual void Spawn()
    {
        this.timer += Time.deltaTime;
        if (this.timer < this.timeDelay) return;
        this.timer = 0;

        Transform newPrefab = Instantiate(this.Obj);
        this.spawnCount++;
        newPrefab.gameObject.SetActive(true);
        newPrefab.SetParent(this.Holder);
    }
}
