using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharDamageSender : DamageSender
{
    [SerializeField] protected CharacterCtrl characterCtrl;
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadRigibody();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadRigibody()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        this._rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        this._rigidbody2D.freezeRotation = true;
        Debug.LogWarning(transform.name + " :LoadRigibody2D", gameObject);
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + " :LoadCharacterCtrl", gameObject);
    }
}
