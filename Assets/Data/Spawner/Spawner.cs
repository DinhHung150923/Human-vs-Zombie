using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : HungMonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> poolObjs;
    [SerializeField] protected Transform Holder;
    protected override void LoadComponent()
    {
        this.LoadPrefab();
        this.LoadHolder();
    }
    protected virtual void LoadHolder()
    {
        if (this.Holder != null) return;
        this.Holder = transform.Find("Holder");
        Debug.LogWarning(transform.name+ "LoadHolder", gameObject);
    }
    protected virtual void LoadPrefab()
    {
        if (this.prefabs.Count > 0) return;
        Transform prefabObj = transform.Find("Prefab");
        foreach (Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }
        this.HidePrefab();
        Debug.LogWarning(transform.name + ": LoadPrefab", gameObject);
    }
    protected virtual void HidePrefab()
    {
        foreach(Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
    public virtual Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
    {
        Transform prefab = this.GetPrefabByName(prefabName);
        if(prefab == null)
        {
            Debug.LogWarning("Prefab not found" + prefab.name);
            return null;
        }
        Transform newprefab = this.GetObjFromPoolObj(prefab);
        newprefab.SetLocalPositionAndRotation(pos, rot);
        newprefab.parent = this.Holder;
        return newprefab;
    }
    protected virtual Transform GetObjFromPoolObj(Transform prefab)
    {
        foreach (Transform poolObj in this.poolObjs)
        {
            if (poolObj.name == prefab.name)
            {
                this.poolObjs.Remove(poolObj);
                return poolObj;
            }
        }
        Transform newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;
    }
    public virtual void DeSpawn(Transform obj)
    {
        this.poolObjs.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach(Transform prefab in this.prefabs)
        {
            if (prefab.name == prefabName) return prefab;
        }
        return null;
    }
}
