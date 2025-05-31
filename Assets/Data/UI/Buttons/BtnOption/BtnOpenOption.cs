using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOpenOption : BtnBaseOption
{
    protected override void Onclick()
    {
        this.option.SetActive(true);
    }
}
