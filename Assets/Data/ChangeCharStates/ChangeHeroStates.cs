using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeroStates : ChangeCharStates
{
    [SerializeField] protected bool IsAttacking = false;
    [SerializeField] protected float timer = 0;
    [SerializeField] protected float timeDamage = 2;
    protected virtual void FixedUpdate()
    {
        this.CheckIsAttacking();
    }
    protected virtual void CheckIsAttacking()
    {
        this.IsAttacking = false;
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.timeDamage) return;
        this.timer = 0;

        this.IsAttacking = true;
    }
    protected override void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.CompareTag("Enemy"))
        {
            this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", true);
            this.characterCtrl.HeroMovement.gameObject.SetActive(false);
        }
    }
    protected virtual void OnTriggerStay(Collider other)
    {
        if(other.transform.parent.CompareTag("Enemy"))
        {
            if (this.IsAttacking)
            {
                this.characterCtrl.DamageSender.SendObj(other.transform);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.CompareTag("Enemy"))
        {
            this.characterCtrl.ModelCtrl.Animator.SetBool("IsAttacking", false);
            this.characterCtrl.HeroMovement.gameObject.SetActive(true);
        } 
    }
}
