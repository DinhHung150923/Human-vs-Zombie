using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseText : HungMonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI text;
    protected override void LoadComponent()
    {
        this.LoadText();
    }
    protected virtual void LoadText()
    {
        if (this.text != null) return;
        this.text = GetComponent<TextMeshProUGUI>();
        Debug.LogWarning(transform.name + "LoadText :", gameObject);
    }
}
