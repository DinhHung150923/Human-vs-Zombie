using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance: Despawn
{
    [SerializeField] protected float distance = 0;
    [SerializeField] protected float disLimit = 50;
    [SerializeField] protected Transform mainCam;
    protected override void LoadComponent()
    {
        this.LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam = Transform.FindObjectOfType<Camera>().transform;
    }
    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.position);
        if(this.distance>this.disLimit)
        {
            return true;
        }
        return false;
    }
}
