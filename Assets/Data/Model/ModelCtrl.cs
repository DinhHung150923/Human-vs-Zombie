using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelCtrl : HungMonobehavior
{
    [SerializeField] protected Animator animator;
    public Animator Animator => animator;
    protected override void LoadComponent()
    {
        this.LoadAnimator();
    }
    protected virtual void LoadAnimator()
    {
        if (this.animator != null) return;
        this.animator = GetComponentInChildren<Animator>();
        Debug.LogWarning(transform.name + " :LoadAnimator", gameObject);
    }
}
