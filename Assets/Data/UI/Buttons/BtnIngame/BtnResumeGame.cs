using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnResumeGame : BaseButton
{
    protected override void Onclick()
    {
        UIManagerInGame.Instance.ClosePauseGame();
        GameManager.Instance.ResumeGame();
    }
}
