using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BtnBaseOption : BaseButton
{
    [SerializeField] protected GameObject option;
    public GameObject Option => option;
    protected override void Start()
    {
        base.Start();
        this.option.SetActive(false);
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadOption();
    }
    protected virtual void LoadOption()
    {
        if (this.option != null) return;
        this.option = GameObject.Find("Option");
        Debug.LogWarning(transform.name + " :LoadOption", gameObject);
    }
}
