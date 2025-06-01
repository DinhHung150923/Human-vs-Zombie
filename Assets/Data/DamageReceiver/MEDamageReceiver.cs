using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEDamageReceiver : DamageReceiver
{
    protected override void LoadCircleCollider2D()
    {
        base.LoadCircleCollider2D();
        this.circleCollider2D.radius = 1.3f;
    }
    protected override void SetHpmax()
    {
        this.hpmax = 50;
    }
    protected override void Ondead()
    {
        UIManagerInGame.Instance.VictoryScreen.SetActive(true);
        GameManager.Instance.PauseGame();
    }
}
