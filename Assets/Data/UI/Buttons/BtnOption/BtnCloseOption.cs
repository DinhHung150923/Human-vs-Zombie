using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCloseOption : BtnBaseOption
{
    protected override void Onclick()
    {
        this.option.SetActive(false);
    }
}
