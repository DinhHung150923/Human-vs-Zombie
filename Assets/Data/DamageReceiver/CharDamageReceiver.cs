using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class CharDamageReceiver : DamageReceiver
{
    [SerializeField] protected CharacterCtrl characterCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + "LoadCharacterCtrl :", gameObject);
    }
    protected override void Reborn()
    {
        base.Reborn();
        this.characterCtrl.ChangeCharState.ChangeMainState(MainState.Moving);
    }
}
