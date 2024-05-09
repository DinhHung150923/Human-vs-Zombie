using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnReStartLevel : BaseButton
{
    protected override void Onclick()
    {
        GameManager.Instance.ReloadScenen();
    }
}
