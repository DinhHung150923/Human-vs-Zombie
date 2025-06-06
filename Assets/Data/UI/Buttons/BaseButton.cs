using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : HungMonoBehaviour
{
    [SerializeField] protected Button button;
    protected override void Start()
    {
        this.AddOnClickEvent();
    }
    protected override void LoadComponent()
    {
        this.LoadButton();
    }
    protected virtual void LoadButton()
    {
        if (this.button != null) return;
        this.button = GetComponent<Button>();
        Debug.LogWarning(transform.name + "LoadButton :", gameObject);
    }
    protected virtual void AddOnClickEvent()
    {
        this.button.onClick.AddListener(this.Onclick);
    }
    protected abstract void Onclick();
}
