using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : HungMonobehavior
{
    [SerializeField] private static InputManager instance;
    public static InputManager Instance => instance;
    [SerializeField] protected float onClick;
    public float OnClick => onClick;
    protected override void Only1Script()
    {
        if (InputManager.instance != null) Debug.LogError("only 1 inputmanager to alow");
        InputManager.instance = this;
    }
    protected override void Update()
    {
        this.Click();
    }
    protected virtual void Click()
    {
        this.onClick = Input.GetAxis("Fire1");
    }
}
