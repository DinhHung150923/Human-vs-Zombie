using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevelStageManager : HungMonobehavior
{
    [SerializeField] private static UILevelStageManager instance;
    public static UILevelStageManager Instance => instance;
    protected override void Only1Script()
    {
        if (UILevelStageManager.instance != null) Debug.LogError("only 1 UILevelStageManager to allow");
        UILevelStageManager.instance = this;
    }
}
