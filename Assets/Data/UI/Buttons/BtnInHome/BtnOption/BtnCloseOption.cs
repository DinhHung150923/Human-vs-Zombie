using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCloseOption : BaseButton
{
    protected override void Onclick()
    {
        UIManagerInHome.Instance.CloseOption();
    }
}
