using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 2f;
    [SerializeField] protected Vector3 direction = Vector3.right;
    protected virtual void Update()
    {
        this.SnakeMovement();
    } 
    protected virtual void SnakeMovement()
    {
        transform.Translate( this.direction*this.speed * Time.deltaTime);
    }
}
