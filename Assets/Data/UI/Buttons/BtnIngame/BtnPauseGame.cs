using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPauseGame : BaseButton
{
    protected override void Onclick()
    {
        GameManager.Instance.PauseGame();
        UIManagerInGame.Instance.OpenPauseGame();
    }
}
