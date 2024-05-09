using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOpenOption : BaseButton
{
    protected override void Onclick()
    {
        UIManagerInHome.Instance.OpenOption();
    }
}
