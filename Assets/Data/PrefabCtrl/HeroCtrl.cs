using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCtrl : HungMonobehavior
{
    [SerializeField] protected Transform model;
    protected override void LoadComponent()
    {
        this.LoadModel();
    }
    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.LogWarning(transform.name + " :LoadModel", gameObject);
    }
}
