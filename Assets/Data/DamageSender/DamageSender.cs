using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class DamageSender : HungMonoBehaviour
{
    [Header("Linked Obj")]
    [SerializeField] protected CharacterCtrl characterCtrl;
    [SerializeField] protected CircleCollider2D circleCollider2D;
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    protected IDamageStrategy damageStrategy;

    protected override void LoadComponent()
    {
        this.LoadCircleCollider2D();
        this.LoadRigibody();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCircleCollider2D()
    {
        if (this.circleCollider2D != null) return;
        this.circleCollider2D = GetComponent<CircleCollider2D>();
        this.circleCollider2D.isTrigger = true;
        this.circleCollider2D.radius = 0.6f;
        Debug.LogWarning(transform.name + " :LoadCircleCollider2D", gameObject);
    }
    protected virtual void LoadRigibody()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        this._rigidbody2D.isKinematic = true;
        Debug.LogWarning(transform.name + " :LoadRigibody", gameObject);
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + " :LoadCharacterCtrl", gameObject);

    }
    protected abstract void OnTriggerEnter(Collider other);
}
