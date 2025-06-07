using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharState : HungMonoBehaviour
{
    public MainState currentMainState = MainState.Idle;
    [SerializeField] protected CharacterCtrl characterCtrl;
    protected override void LoadComponent()
    {
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + " :LoadCharacterCtrl", gameObject);

    }
    // chuyen trang thai co ban cua nhan vat
    public virtual void ChangeMainState(MainState newState)
    {

        if (this.currentMainState == newState) return;

        this.currentMainState = newState;
        Debug.Log($"Enemy chuy?n sang tr?ng thái: {currentMainState}");

        //  goi animation týõng ung 
        switch (newState)
        {
            case MainState.Idle:
                this.characterCtrl.Movement.gameObject.SetActive(false);
                this.characterCtrl.ModelCtrl.Animator.SetBool("IsMoving",false);
                Debug.Log("Idle");
                break;
            case MainState.Moving:
                this.characterCtrl.Movement.gameObject.SetActive(true);
                this.characterCtrl.ModelCtrl.Animator.SetBool("IsMoving", true);
                Debug.Log("Moving");
                break;
            case MainState.Attacking:
                this.characterCtrl.Movement.gameObject.SetActive(false);
                this.characterCtrl.ModelCtrl.Animator.SetTrigger("Attack");
                Debug.Log("Attacking");
                break;
            case MainState.Dying:
                this.characterCtrl.ModelCtrl.Animator.SetTrigger("Die");
                Debug.Log("Dying");
                break;
        }
    }
}
