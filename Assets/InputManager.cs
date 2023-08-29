using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private static InputManager instance;
    public static InputManager Instance => instance;
    protected Vector4 direction;
    public Vector4 Direction => direction;
    [SerializeField] protected Vector3 currentDirection;
    public Vector3 CurrentDirection => currentDirection;
    protected virtual void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("only 1 inputmanager to alow");
        InputManager.instance = this;
    }
    protected virtual void Start()
    {
        this.currentDirection = Vector3.right;
    }
    protected virtual void Update()
    {
        this.GetDirectionFromKey();
        this.ChangeDirection();
    }
    protected virtual void GetDirectionFromKey()
    {
        this.direction.x = Input.GetKeyDown(KeyCode.A) ? 1 : 0;
        if(this.direction.x==0) this.direction.x = Input.GetKeyDown(KeyCode.LeftArrow) ? 1 : 0;

        this.direction.y = Input.GetKeyDown(KeyCode.D) ? 1 : 0;
        if (this.direction.y == 0) this.direction.y = Input.GetKeyDown(KeyCode.RightArrow) ? 1 : 0;

        this.direction.z = Input.GetKeyDown(KeyCode.W) ? 1 : 0;
        if (this.direction.z == 0) this.direction.z = Input.GetKeyDown(KeyCode.UpArrow) ? 1 : 0;

        this.direction.w = Input.GetKeyDown(KeyCode.S) ? 1 : 0;
        if (this.direction.w == 0) this.direction.w = Input.GetKeyDown(KeyCode.DownArrow) ? 1 : 0;
    }
    protected virtual void ChangeDirection()
    {
        if (this.direction.x == 1) this.currentDirection = Vector3.left;
        if (this.direction.y == 1) this.currentDirection = Vector3.right;
        if (this.direction.z == 1) this.currentDirection = Vector3.up;
        if (this.direction.w == 1) this.currentDirection = Vector3.down;
    }
}
