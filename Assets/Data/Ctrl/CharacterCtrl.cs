using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : HungMonoBehaviour
{
    [SerializeField] protected ModelCtrl modelCtrl;
    public ModelCtrl ModelCtrl => modelCtrl;
    [SerializeField] protected Movement movement;
    public Movement Movement => movement;
    [SerializeField] protected ChangeCharState changeCharState;
    public ChangeCharState ChangeCharState => changeCharState;
    [SerializeField] protected CharAttack charAttack;
    public CharAttack CharAttack => charAttack;
    protected override void LoadComponent()
    {
        this.LoadModel();
        this.LoadHeroMovement();
        this.LoadChangeCharState();
        this.LoadCharAttack();
    }
    protected virtual void LoadModel()
    {
        if (this.modelCtrl != null) return;
        this.modelCtrl = GetComponentInChildren<ModelCtrl>();
        Debug.LogWarning(transform.name + " :LoadModel", gameObject);
    }
    protected virtual void LoadHeroMovement()
    {
        if (this.movement != null) return;
        this.movement = GetComponentInChildren<Movement>();
        Debug.LogWarning(transform.name + " :LoadMovement", gameObject);
    }
    protected virtual void LoadChangeCharState()
    {
        if (this.changeCharState != null) return;
        this.changeCharState = GetComponentInChildren<ChangeCharState>();
        Debug.LogWarning(transform.name + " :LoadChangeCharState", gameObject);
    }
    protected virtual void LoadCharAttack()
    {
        if (this.charAttack != null) return;
        this.charAttack = GetComponentInChildren<CharAttack>();
        Debug.LogWarning(transform.name + " :LoadCharAttack", gameObject);
    }
}